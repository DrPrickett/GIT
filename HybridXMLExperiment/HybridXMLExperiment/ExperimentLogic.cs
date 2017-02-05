using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace HybridXMLExperiment
{
    public class ExperimentLogic
    {
        public delegate void StatusUpdateHandler(object sender, Results e);
        public event StatusUpdateHandler OnResultsUpdated;

        public List<Results> RunExperiment(string @CSVInputFileWithRunPlan,string @CSVResultsOuputFile)
        {
            List<Results> Ouput = new List<Results>();
            StreamReader SR = new StreamReader(CSVInputFileWithRunPlan);
            int rcount = 1;
            
            while (!SR.EndOfStream)
            {
                string thisLine = SR.ReadLine();
                if (rcount > 1)
                {
                    
                    Results thisItem = new Results();
                    thisItem.TITLE = thisLine.Split(',')[0];
                    thisItem.COMPRESSED = thisLine.Split(',')[1];
                    thisItem.KEYWORD = thisLine.Split(',')[2];
                    thisItem.RUNORDER = Convert.ToInt32(thisLine.Split(',')[4]);
                    thisItem.BASEFILENAME = thisLine.Split(',')[5];
                    thisItem.REMOTEFILELOCATION = thisLine.Split(',')[6];
                    thisItem.LOCALFILELOCATION = thisLine.Split(',')[7];
                    
                    Ouput.Add(thisItem);
                    
                    
                }
                rcount++;
            }
            SR.Close();
            foreach(Results r in Ouput)
            {
                thisExperimentRun(r);
                
            }

            return Ouput;
        }
        
        private Results thisExperimentRun(Results thisRun)
        {
            DateTime starttime = DateTime.Now;
            File.Copy(@thisRun.REMOTEFILELOCATION, @thisRun.LOCALFILELOCATION,true);
            
            DateTime endtime = DateTime.Now;
            
            

            TimeSpan TS = endtime.Subtract(starttime);
            
            thisRun.TOTALTIME = Convert.ToDecimal(TS.Milliseconds);
            UpdateResults(thisRun);
            //Thread.Sleep(100);
            return thisRun;
        }
        public class Results
        {
            public string COMPRESSED { get; set; }
            public string KEYWORD { get; set; }
            public string TITLE { get; set; }
            public decimal TOTALTIME { get; set; }
            public Int32 RUNORDER { get; set; }
            public string BASEFILENAME { get; set; }
            public string REMOTEFILELOCATION { get; set; }
            public string LOCALFILELOCATION { get; set; }
        }
        private void UpdateResults(Results results)
        {
            // Make sure someone is listening to event
            if (OnResultsUpdated == null) return;
            OnResultsUpdated(this, results);
        }
    }

}
