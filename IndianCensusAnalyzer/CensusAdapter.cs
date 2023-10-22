using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianCensusAnalyzer
{
    public class CensusAdapter
    {
        protected string[] GetCensusData(string csvfilePath, string dataHeaders)
        {
            string[] censusData;
            if (!File.Exists(csvfilePath))
            {
                throw new CensusAnalyserException
                    ("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvfilePath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid file type",
                    CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvfilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in data",
                    CensusAnalyserException.ExceptionType.INCORRECT_HEADRER);

            }
            return censusData;
        }
    }
}
