using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.cloud.cloudpromo.aichat.file.upload
    /// </summary>
    public class AlipayCloudCloudpromoAichatFileUploadRequest : IAopUploadRequest<AlipayCloudCloudpromoAichatFileUploadResponse>
    {
        /// <summary>
        /// 用户唯一标识，由客户生成
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// 文件内容的二进制流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文件后缀名
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// 文件id，首次上传文件时由问答系统生成并返回给调用方。
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件用途
        /// </summary>
        public string FileUsage { get; set; }

        /// <summary>
        /// 当后缀file_extension为xlsx/xls/csv/json时，index_column字段传值，表示对文件内容中指定的一级字段/列名建立优化索引；如果没有传递该值或不属于上述后缀，表示不针对字段级别建立索引。
        /// </summary>
        public string IndexColumn { get; set; }

        /// <summary>
        /// 场景唯一标识，由客户提供
        /// </summary>
        public string SceneId { get; set; }

        /// <summary>
        /// 会话ID，由客户生成
        /// </summary>
        public string SessionId { get; set; }

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
            return "alipay.cloud.cloudpromo.aichat.file.upload";
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
            parameters.Add("customer_id", this.CustomerId);
            parameters.Add("file_extension", this.FileExtension);
            parameters.Add("file_id", this.FileId);
            parameters.Add("file_name", this.FileName);
            parameters.Add("file_usage", this.FileUsage);
            parameters.Add("index_column", this.IndexColumn);
            parameters.Add("scene_id", this.SceneId);
            parameters.Add("session_id", this.SessionId);
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
