using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ins.data.auto.coefficient.sync
    /// </summary>
    public class AlipayInsDataAutoCoefficientSyncRequest : IAopUploadRequest<AlipayInsDataAutoCoefficientSyncResponse>
    {
        /// <summary>
        /// csv文件
        /// </summary>
        public FileItem CoeffecientTableContent { get; set; }

        /// <summary>
        /// 同步表id，每次同步的系数表应有唯一可辨认的id
        /// </summary>
        public string CoeffecientTableId { get; set; }

        /// <summary>
        /// 同步系数表的条目数量
        /// </summary>
        public Nullable<long> CoeffecientTableSize { get; set; }

        /// <summary>
        /// 请求id，每次请求唯一
        /// </summary>
        public string RequestId { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

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
            return "alipay.ins.data.auto.coefficient.sync";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("coeffecient_table_id", this.CoeffecientTableId);
            parameters.Add("coeffecient_table_size", this.CoeffecientTableSize);
            parameters.Add("request_id", this.RequestId);
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
            parameters.Add("coeffecient_table_content", this.CoeffecientTableContent);
            return parameters;
        }

        #endregion
    }
}
