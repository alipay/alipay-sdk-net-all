using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ant.merchant.expand.stockmove.file.upload
    /// </summary>
    public class AntMerchantExpandStockmoveFileUploadRequest : IAopUploadRequest<AntMerchantExpandStockmoveFileUploadResponse>
    {
        /// <summary>
        /// 文件字节流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 上传文件的格式：XLSX,TXT等
        /// </summary>
        public string FileFormat { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件url
        /// </summary>
        public string FileUrl { get; set; }

        /// <summary>
        /// 库存变动周期结束时间，一般是前一天的23点59分59秒
        /// </summary>
        public string TimePeriodEnd { get; set; }

        /// <summary>
        /// 库存变动周期开始时间，一般是前一天的0点
        /// </summary>
        public string TimePeriodStart { get; set; }

        /// <summary>
        /// 上传的excel文件中的行数
        /// </summary>
        public Nullable<long> TotalCount { get; set; }

        /// <summary>
        /// 文件上传批次号，每天的批次号是唯一的
        /// </summary>
        public string UploadBatchNo { get; set; }

        /// <summary>
        /// 上传的类型：分为文件上传和连接上传
        /// </summary>
        public string UploadFormat { get; set; }

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
            return "ant.merchant.expand.stockmove.file.upload";
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
            parameters.Add("file_format", this.FileFormat);
            parameters.Add("file_name", this.FileName);
            parameters.Add("file_url", this.FileUrl);
            parameters.Add("time_period_end", this.TimePeriodEnd);
            parameters.Add("time_period_start", this.TimePeriodStart);
            parameters.Add("total_count", this.TotalCount);
            parameters.Add("upload_batch_no", this.UploadBatchNo);
            parameters.Add("upload_format", this.UploadFormat);
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
