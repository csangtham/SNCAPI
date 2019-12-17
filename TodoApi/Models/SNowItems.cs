using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class OpenReqItems
    {
        //Request items
        public string K2ReqId { get; set; }
        public string Stie { get; set; }
        public string TpReqID { get; set; }
        public string TpFileName { get; set; }

        public OpenReqItems()
        {
            Clear();
        }

        public void Clear()
        {
            K2ReqId = "";
            Stie = "";
            TpReqID = "";
            TpFileName = "";
        }

        public static OpenReqItems snowOpenReqItems = new OpenReqItems();
    }

    public class OpenReplyItems
    {
        //Reply items
        public string SNowReqNo { get; set; }
        public string SNowRitmNo { get; set; }
        public string SNowTaskNo { get; set; }

        public OpenReplyItems()
        {
            Clear();
        }

        public void Clear()
        {
            SNowReqNo = "";
            SNowRitmNo = "";
            SNowTaskNo = "";
        }

        public static OpenReplyItems snowOpenReplyItems = new OpenReplyItems();
    }

    public class CloseReqItems
    {
        public string K2ReqId { get; set; }
        public string SNowTaskNo { get; set; }

        public CloseReqItems()
        {
            Clear();
        }

        public void Clear()
        {
            K2ReqId = "";
            SNowTaskNo = "";
        }

        public static CloseReqItems snowCloseReqItems = new CloseReqItems();
    }

    public class CloseReplyItems
    {
        public bool IsClosed { get; set; }

        public CloseReplyItems()
        {
            Clear();
        }

        public void Clear()
        {
            IsClosed = false;
        }

        public static CloseReplyItems snowCloseReplyItems = new CloseReplyItems();
    }

    public class INI
    {
        public string OpenTicketFilePath;
        public string OpenTicketFileArchPath;
        public string CloseTicketFilePath;
        public string CloseTicketFileArchPath;
        public float WaitReplyFileTimeOutSec;
        public bool EnableBackupFile;

    }

}
