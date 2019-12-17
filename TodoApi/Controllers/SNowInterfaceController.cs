using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SNowInterfaceController : ControllerBase
    {
        private string ErrMsg = "";
        private readonly IConfiguration Config = null;
        public SNowInterfaceController(IConfiguration configuration)
        {
            Config = configuration;
            //INI.iNI.OpenTicketFilePath = Config.GetSection("FilePath:OpenTicketFilePath").Value;
            //INI.iNI.OpenTicketFileArchPath = Config.GetSection("FilePath:OpenTicketFileArchPath").Value;
            //INI.iNI.CloseTicketFilePath = Config.GetSection("FilePath:CloseTicketFilePath").Value;
            //INI.iNI.CloseTicketFileArchPath = Config.GetSection("FilePath:CloseTicketFileArchPath").Value;
            //INI.iNI.WaitReplyFileTimeOutSec = Convert.ToSingle(Config.GetSection("FilePath:WaitReplyFileTimeOutSec").Value);
            //INI.iNI.EnableBackupFile = Boolean.Parse(Config.GetSection("FilePath:EnableBackupFile").Value);
        }

        // GET: api/SNowInterface
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        // GET: api/SNowInterface/OpenedTicket/K2_123456789
        [HttpGet("OpenedTicket/{K2ReqId}")]
        public IActionResult GetOpenedTicket(string K2ReqId)
        {
            bool Success = false;

            //Check required items 
            if (string.IsNullOrEmpty(K2ReqId))
            {
                ErrMsg = string.Format("K2 Request ID is required, please try again, sK2ReqId={0}", K2ReqId);

                return BadRequest(ErrMsg);
            }
            else
            {
                return Ok();
                //Clear OpenReplyItems to default values
                //OpenReplyItems ReplyItems = new OpenReplyItems();

                ////Read reply file from SNC.SVC.TPToolTicketAutomation app
                //Success = appFile.ReadOpenedTicketReplyFile(K2ReqId, ref ReplyItems, INI.iNI.OpenTicketFilePath, INI.iNI.OpenTicketFileArchPath, INI.iNI.WaitReplyFileTimeOutSec, ref ErrMsg);

                //if (Success)
                //    return Ok(ReplyItems);
                //else
                //    return StatusCode(500, ErrMsg); //500 Internal Server Error
            }
        }

        // GET: api/SNowInterface/IsClosedTicket/K2_123456789
        [HttpGet("IsClosedTicket/{sK2ReqId}")]
        public IActionResult GetIsCloseTicket(string K2ReqId)
        {
            bool Success = false;

            //Clear CloseReplyItems to default values
            CloseReplyItems ReplyItems = new CloseReplyItems();

            //Check required items 
            if (string.IsNullOrEmpty(K2ReqId))
            {
                ErrMsg = string.Format("K2 Request ID is required, please try again, sK2ReqId={0}", K2ReqId);

                return BadRequest(ErrMsg);
            }
            else
            {
                return Ok();
                //Read reply file from SNC.SVC.TPToolTicketAutomation app
                //Success = appFile.ReadClosedTicketReplyFile(K2ReqId, ref ReplyItems, INI.iNI.CloseTicketFilePath, INI.iNI.CloseTicketFileArchPath, INI.iNI.WaitReplyFileTimeOutSec, ref ErrMsg);

                //if (Success)
                //    return Ok(ReplyItems);
                //else
                //    return StatusCode(500, ErrMsg); //500 Internal Server Error
            }
        }

        // POST: api/SNowInterface/ticket/open
        [HttpPost("ticket/open")]
        public async Task<IActionResult> PostOpenTicketAsync(OpenReqItems ReqItems)
        {
            bool bSuccess = false;

            //Check required items 
            if (string.IsNullOrEmpty(ReqItems.K2ReqId) || string.IsNullOrEmpty(ReqItems.Stie) || string.IsNullOrEmpty(ReqItems.TpReqID) || string.IsNullOrEmpty(ReqItems.TpFileName))
            {
                ErrMsg = string.Format("The following parameters can not be null: sK2ReqId={0}, sStie={1}," +
                    "sTestProgReqID={2}, sTpFileName={3}", ReqItems.K2ReqId, ReqItems.Stie, ReqItems.TpReqID, ReqItems.TpFileName);

                return BadRequest(ErrMsg);
            }
            else
            {
                //bSuccess = appFile.WriteOpenTicketRequestFile(ReqItems, INI.iNI.OpenTicketFilePath, INI.iNI.OpenTicketFileArchPath, ref ErrMsg);

                //if(bSuccess)
                //    return CreatedAtAction(nameof(Get), ReqItems); //201 created
                //else
                //    return StatusCode(500, ErrMsg); //500 Internal Server Error
                return Ok();
            }
        }

        // POST: api/SNowInterface/ticket/close
        [HttpPost("ticket/close")]
        public async Task<IActionResult> PostCloseTicketAsync(CloseReqItems CloseReqItems)
        {
            bool Success = false;

            //Check required items 
            if (string.IsNullOrEmpty(CloseReqItems.K2ReqId) || string.IsNullOrEmpty(CloseReqItems.SNowTaskNo))
            {
                ErrMsg = string.Format("The following parameters can not be null: sK2ReqId={0}, sSNowTaskNo={1}", CloseReqItems.K2ReqId, CloseReqItems.SNowTaskNo);

                return BadRequest(ErrMsg);
            }
            else
            {
                //Success = appFile.WriteCloseTicketRequestFile(CloseReqItems, INI.iNI.CloseTicketFilePath, INI.iNI.CloseTicketFileArchPath, ref ErrMsg);

                //if (Success)
                //    return CreatedAtAction(nameof(Get), CloseReqItems); //201 created
                //else
                //    return StatusCode(500, ErrMsg); //500 Internal Server Error
                return Ok();
            }
        }
    }
}
