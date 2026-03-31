using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.provider.npassporter.face.verify
    /// </summary>
    public class AlipayOfflineProviderNpassporterFaceVerifyRequest : IAopUploadRequest<AlipayOfflineProviderNpassporterFaceVerifyResponse>
    {
        /// <summary>
        /// 用户在支付宝uid
        /// </summary>
        public string AlipayId { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 用户在支付宝uid
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 照片URL
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        public string SolutionType { get; set; }

        /// <summary>
        /// 接入方传入具体活动场次唯一ID即可，此字段作为密算证件号的关键信息，即同一场次下的人群传统一ID即可，若不填写默认以“projectID”字段作为密算计算信息。接入方调用支付宝传入的场次ID，需跟自己按密算规则传入的ID保持一致，否则会出现两侧密算后信息无法匹配。
        /// </summary>
        public string SubProjectId { get; set; }

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
            return "alipay.offline.provider.npassporter.face.verify";
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
            parameters.Add("alipay_id", this.AlipayId);
            parameters.Add("open_id", this.OpenId);
            parameters.Add("photo_url", this.PhotoUrl);
            parameters.Add("project_id", this.ProjectId);
            parameters.Add("solution_type", this.SolutionType);
            parameters.Add("sub_project_id", this.SubProjectId);
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
