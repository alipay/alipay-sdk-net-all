using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.merchant.meterial.upload
    /// </summary>
    public class AlipayEbppMerchantMeterialUploadRequest : IAopUploadRequest<AlipayEbppMerchantMeterialUploadResponse>
    {
        /// <summary>
        /// 文件二进制
        /// </summary>
        public FileItem Content { get; set; }

        /// <summary>
        /// 实体创建时对应的code，如小区或物业的shortName。当entity_type=RELATIONSHIP时，entity_code=关系id
        /// </summary>
        public string EntityCode { get; set; }

        /// <summary>
        /// 实体类型： COMMUNITY_COMPANY("COMMUNITY_COMPANY", "物业"), OMMUNITY_INFO("COMMUNITY_INFO", "小区"), COMMUNITY_ISV("COMMUNITY_ISV", "ISV"), RELATIONSHIP("RELATIONSHIP", "物业小区绑定关系"), EXTERNAL_BILL_INFO("EXTERNAL_BILL_INFO", "账单"),;
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        public string FileDesc { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

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
            return "alipay.ebpp.merchant.meterial.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("entity_code", this.EntityCode);
            parameters.Add("entity_type", this.EntityType);
            parameters.Add("file_desc", this.FileDesc);
            parameters.Add("file_name", this.FileName);
            parameters.Add("memo", this.Memo);
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
            parameters.Add("content", this.Content);
            return parameters;
        }

        #endregion
    }
}
