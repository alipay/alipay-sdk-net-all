using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.merchant.indirect.file.upload
    /// </summary>
    public class AlipayMerchantIndirectFileUploadRequest : IAopUploadRequest<AlipayMerchantIndirectFileUploadResponse>
    {
        /// <summary>
        /// 文件二进制流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文件名(用于幂等),构造字段时，可使用年月日_报告类型来处理。
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型，目前仅支持txt
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 间联小程序ID
        /// </summary>
        public string MrchindAppId { get; set; }

        /// <summary>
        /// 当前文件的记录总数(校验用)
        /// </summary>
        public Nullable<long> RecordCount { get; set; }

        /// <summary>
        /// 报告类型，(DAILY/WEEK/MONTH)
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// 报告周期的结束时间，时间格式为yyyy-MM-dd，默认为当天0点
        /// </summary>
        public Nullable<DateTime> TimePeriodEnd { get; set; }

        /// <summary>
        /// 报告周期的起始时间，时间格式为yyyy-MM-dd，默认为当天0点
        /// </summary>
        public Nullable<DateTime> TimePeriodStart { get; set; }

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
            return "alipay.merchant.indirect.file.upload";
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
            parameters.Add("file_name", this.FileName);
            parameters.Add("file_type", this.FileType);
            parameters.Add("mrchind_app_id", this.MrchindAppId);
            parameters.Add("record_count", this.RecordCount);
            parameters.Add("report_type", this.ReportType);
            parameters.Add("time_period_end", this.TimePeriodEnd);
            parameters.Add("time_period_start", this.TimePeriodStart);
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
