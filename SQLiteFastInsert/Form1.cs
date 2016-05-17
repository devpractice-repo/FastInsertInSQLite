using System;
using System.Windows.Forms;
using System.Threading;

using System.Data.SQLite;
using System.IO;


namespace SQLiteFastInsert
{
    public partial class Form1 : Form
    {        
        private int intervalOfTimer;
        private int countOfInsertsInTrns;
        private int insertsCounter;

        // Vars for work with DB
        private String dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        private String[] insertsPoll;

        // Vars for thread
        private Thread threadDbWorker;
        private bool isThreadRun;
        private bool stopThread;
                

        public Form1()
        {
            InitializeComponent();                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Interface tuning
            tbTimeOfExperiment.Text = intervalOfTimer.ToString();
            tbInsCount.Text = countOfInsertsInTrns.ToString();
            btStop.Enabled = false;

            // Init vars
            intervalOfTimer = 0;
            countOfInsertsInTrns = 0;
            insertsCounter = 0;
            isThreadRun = false;
            stopThread = true;
            
            // Prepare DB vars for work
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "sample.sqlite";

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Test (id INTEGER PRIMARY KEY AUTOINCREMENT, message TEXT)";
                m_sqlCmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {    
            // Time of experiment and INSERTs in transaction        
            if(Int32.TryParse(tbTimeOfExperiment.Text, out intervalOfTimer))
            {
                if(intervalOfTimer <= 0)
                {
                    MessageBox.Show("Time of experiment must be higher then zero!");
                    return;
                }
            }

            if(Int32.TryParse(tbInsCount.Text, out countOfInsertsInTrns))
            {
                if(countOfInsertsInTrns <= 0)
                {
                    MessageBox.Show("Count of INSERTs must be higher then zero!");
                    return;
                }
            }

            // Run experiment
            DbWorker();
            
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            // Stop experiment
            DbWorker();
        }

        private void DbWorker()
        {
            if(isThreadRun)
            {
                // Prep interface
                btStart.Enabled = true;
                btStop.Enabled = false;

                // Set flags
                stopThread = true;
                isThreadRun = false;

                // Timer off
                timerDb.Enabled = false;                
            }
            else
            {
                // Prep interface
                btStart.Enabled = false;
                btStop.Enabled = true;
                lbCountOfInsertsValue.Text = "-------";
                lbInsPerSecValue.Text = "-------";

                // Set flags
                isThreadRun = true;
                stopThread = false;

                // Run thread
                threadDbWorker = new Thread(writeDataToDb);
                threadDbWorker.Start();

                // Timer on
                timerDb.Interval = intervalOfTimer * 1000;
                timerDb.Enabled = true;                
            }
        }

            private void writeDataToDb()
            {            
                String query = "INSERT INTO Test ('message') values ('Hello message')";
                while (!stopThread)
                {
                    if (countOfInsertsInTrns == 1)
                    {
                        m_sqlCmd = new SQLiteCommand(query, m_sqlCmd.Connection);
                        m_sqlCmd.ExecuteNonQuery();
                        insertsCounter++;
                    }
                    else
                    {
                        m_sqlCmd = new SQLiteCommand("begin", m_sqlCmd.Connection);
                        m_sqlCmd.ExecuteNonQuery();
                        //---INSIDE LOOP
                        for (int i = 0; i < countOfInsertsInTrns; i++)
                        {
                            m_sqlCmd = new SQLiteCommand(query, m_sqlCmd.Connection);
                            m_sqlCmd.ExecuteNonQuery();
                            insertsCounter++;
                        }
                        //---END LOOP
                        m_sqlCmd = new SQLiteCommand("end", m_sqlCmd.Connection);
                        m_sqlCmd.ExecuteNonQuery();
                    }
                }
            }

       

        private void timerDb_Tick(object sender, EventArgs e)
        {
            // Stop timer
            timerDb.Stop();
            timerDb.Enabled = false;

            // Stop thread
            if (isThreadRun)                         
                stopThread = true;
         
            DbWorker();

            // Calc metrics
            float avrg = ((float)insertsCounter) / intervalOfTimer;
            lbCountOfInsertsValue.Text = insertsCounter.ToString();
            lbInsPerSecValue.Text = avrg.ToString();
        }
    }
}
