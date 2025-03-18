using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.rent.enterprise.seal.sign
    /// </summary>
    public class AlipayCommerceRentEnterpriseSealSignRequest : IAopUploadRequest<AlipayCommerceRentEnterpriseSealSignResponse>
    {
        /// <summary>
        /// 业务描述
        /// </summary>
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string BizName { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 上传的合同PDF文件
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 预授权订单号
        /// </summary>
        public string PreAuthNo { get; set; }

        /// <summary>
        /// 企业签署区域信息
        /// </summary>
        public SignAreaRequest SignAreaOrg { get; set; }

        /// <summary>
        /// 用户个人签署区域信息
        /// </summary>
        public SignAreaRequest SignAreaPerson { get; set; }

        /// <summary>
        /// 签署用户身份证件号
        /// </summary>
        public string SignerUserCertNumber { get; set; }

        /// <summary>
        /// 签署用户个人姓名
        /// </summary>
        public string SignerUserName { get; set; }

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
            return "alipay.commerce.rent.enterprise.seal.sign";
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
            parameters.Add("biz_desc", this.BizDesc);
            parameters.Add("biz_name", this.BizName);
            parameters.Add("biz_no", this.BizNo);
            parameters.Add("pre_auth_no", this.PreAuthNo);
            parameters.Add("sign_area_org", this.SignAreaOrg);
            parameters.Add("sign_area_person", this.SignAreaPerson);
            parameters.Add("signer_user_cert_number", this.SignerUserCertNumber);
            parameters.Add("signer_user_name", this.SignerUserName);
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
