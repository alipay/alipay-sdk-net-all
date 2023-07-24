using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: datadigital.fincloud.generalsaas.face.source.certify
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceSourceCertifyRequest : IAopUploadRequest<DatadigitalFincloudGeneralsaasFaceSourceCertifyResponse>
    {
        /// <summary>
        /// 用户姓名，与身份证上的姓名相匹配
        /// </summary>
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码，如大陆身份证号码
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 证件信息类型，大陆身份证：IDENTITY_CARD
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 二进制流图片，大小限制1M
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 活体检测类型，当前枚举支持： OFF：关闭活体检测； CHECK：正常活体检测。 不传默认CHECK。
        /// </summary>
        public string LivenessStrategy { get; set; }

        /// <summary>
        /// 客户业务单据号
        /// </summary>
        public string OuterBizNo { get; set; }

        /// <summary>
        /// 手机号，特殊场景下，在验证过程中需用户输入手机来接受系统发送的安全验证短信。默认不传即可。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// true：需要留底；false：无需留底。默认留底
        /// </summary>
        public Nullable<bool> Reserved { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=true;
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
            return "datadigital.fincloud.generalsaas.face.source.certify";
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
            parameters.Add("cert_name", this.CertName);
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("liveness_strategy", this.LivenessStrategy);
            parameters.Add("outer_biz_no", this.OuterBizNo);
            parameters.Add("phone", this.Phone);
            parameters.Add("reserved", this.Reserved);
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
