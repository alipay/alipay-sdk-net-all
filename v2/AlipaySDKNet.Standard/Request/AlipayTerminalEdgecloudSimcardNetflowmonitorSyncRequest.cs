using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.terminal.edgecloud.simcard.netflowmonitor.sync
    /// </summary>
    public class AlipayTerminalEdgecloudSimcardNetflowmonitorSyncRequest : IAopUploadRequest<AlipayTerminalEdgecloudSimcardNetflowmonitorSyncResponse>
    {
        /// <summary>
        /// 当upload_monitor_scene为SIM_CARD_NETFLOW_DAY或SIM_CARD_POOL_NETFLOW_DAY时，biz_date格式为yyyymmdd。当upload_monitor_scene为SIM_CARD_NETFLOW_MONTH时，biz_date格式为yyyymm
        /// </summary>
        public string BizDate { get; set; }

        /// <summary>
        /// 文件序列号从1开始递增，且必须连续递增
        /// </summary>
        public Nullable<long> BizDateFileSeqId { get; set; }

        /// <summary>
        /// 同步文件二进制字节流，必须是CSV文件，大小必须小于50M
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// SIM_CARD_NETFLOW_DAY(sim卡流量天级别监控) SIM_CARD_NETFLOW_MONTH(sim卡流量月级别监控) SIM_CARD_POOL_NETFLOW_DAY(sim流量池天级别监控)
        /// </summary>
        public string UploadMonitorScene { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;
        private Dictionary<string, string> udfParams; //add user-defined text parameters

    	 public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

		public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.terminal.edgecloud.simcard.netflowmonitor.sync";
        }

        public void PutOtherTextParam(string key, string value) 
        {
            if(this.udfParams == null) 
            {
                this.udfParams = new Dictionary<string, string>();
            }
            this.udfParams.Add(key, value);
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_date", this.BizDate);
            parameters.Add("biz_date_file_seq_id", this.BizDateFileSeqId);
            parameters.Add("upload_monitor_scene", this.UploadMonitorScene);
            if(udfParams != null) 
            {
                parameters.AddAll(this.udfParams);
            }
            return parameters;
        }
		
		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion

        #region IAopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("file_content", this.FileContent);
            return parameters;
        }

        #endregion
    }
}
