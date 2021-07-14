using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;

namespace ExcelReleaseTool
{
    public interface IFileCheck
    {
        void contentCheck();
    }
    public class IPPCFileCheck : IFileCheck
    {
        public void contentCheck()
        {

        }
    }
    public class ILMOFileCheck : IFileCheck
    {
        public void contentCheck()
        {

        }
    }
    public class IPBomFileCheck : IFileCheck
    {
        public void contentCheck()
        {

        }
    }
    public class IUBomFileCheck : IFileCheck
    {
        public void contentCheck()
        {

        }
    }
    public  class ImFile
    {
        private string fileName;
        protected IFileCheck fileCheck;
        public string FileName
        {
            get
            {
                return string.IsNullOrEmpty(fileName) ? "空" :fileName;
            }
            set
            {
                fileName = string.IsNullOrEmpty(value) ? "空" : value;
            }
        }
   
        //public Boolean fileOK;
        public void fileContentCheck()
        {
            fileCheck.contentCheck();
        }
        //public Boolean FileExists()
        //{
        //    if (File.Exists(this.fileDir)) return true;
        //    else return false;
        //}
    }
    public class PPCFile : ImFile
    {
        public static string FileDir{ set; get; }
        public PPCFile()
        {
            fileCheck = new IPPCFileCheck();
        }
    }

    public class UBomFile : ImFile
    {
        public UBomFile()
        {
            fileCheck = new IUBomFileCheck();
        }
        public static string FileDir { set; get; }
    }

    public class LMOFile : ImFile
    {
        public static string FileDir { set; get; }
        public LMOFile()
        {
            fileCheck = new ILMOFileCheck();
        }
    }

    public class PBomFile : ImFile
    {
        public static string FileDir { set; get; }
        public PBomFile()
        {
            fileCheck = new IPBomFileCheck();
        }
    }

}
