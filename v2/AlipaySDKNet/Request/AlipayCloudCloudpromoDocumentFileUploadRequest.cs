using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.cloud.cloudpromo.document.file.upload
    /// </summary>
    public class AlipayCloudCloudpromoDocumentFileUploadRequest : IAopUploadRequest<AlipayCloudCloudpromoDocumentFileUploadResponse>
    {
        /// <summary>
        /// API-Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// MIME TYPE
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 客户id 
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// 应用数据ID（创建应用数据时为空，更新需指定应用数据ID）
        /// </summary>
        public string DocumentId { get; set; }

        /// <summary>
        /// 上传文件的二进制流（最大20MB）
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 操作人标识 
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 数据处理规则
        /// </summary>
        public DocumentProcessRule ProcessRule { get; set; }

        /// <summary>
        /// 表结构配置
        /// </summary>
        public TableSchema TableSchema { get; set; }

        /// <summary>
        /// 空间ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string Type { get; set; }

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
            return "alipay.cloud.cloudpromo.document.file.upload";
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
            parameters.Add("api_key", this.ApiKey);
            parameters.Add("content_type", this.ContentType);
            parameters.Add("customer_id", this.CustomerId);
            parameters.Add("document_id", this.DocumentId);
            parameters.Add("operator", this.Operator);
            parameters.Add("process_rule", this.ProcessRule);
            parameters.Add("table_schema", this.TableSchema);
            parameters.Add("tenant_id", this.TenantId);
            parameters.Add("type", this.Type);
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
