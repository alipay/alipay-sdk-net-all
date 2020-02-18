using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ssdata.dataservice.risk.businesslicense.certify
    /// </summary>
    public class SsdataDataserviceRiskBusinesslicenseCertifyRequest : IAopUploadRequest<SsdataDataserviceRiskBusinesslicenseCertifyResponse>
    {
        /// <summary>
        /// 营业执照的公司地址 【非图片认证时此参数必填】
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 业务唯一识别码，总体流程为图片认证，如果有疑义可以再次触发接口，进行手动修改配置验证用户信息(即：当上传的图片为空时），此时biz_id需要设置为图片认证时返回的bis_token值，不然将重复计费  【非图片认证时此参数必填】
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 营业执照上的统一信用码【非图片认证时此参数必填】
        /// </summary>
        public string CreditCode { get; set; }

        /// <summary>
        /// 营业执照法人名称 【非图片认证时此参数必填】
        /// </summary>
        public string EntLegalName { get; set; }

        /// <summary>
        /// 营业执照上的企业名称 【非图片认证时此参数必填】
        /// </summary>
        public string EntName { get; set; }

        /// <summary>
        /// 二进制文件流 ,图片大小小于10M（图片越大上传耗时比较大），格式jpg,png、bmp等常用图片格式都可以，如果设置图片，即为图片认证，图片认证时其他字段可全部为空  【图片认证时此参数必填】
        /// </summary>
        public FileItem EntProsPic { get; set; }

        /// <summary>
        /// 营业执照营业期限，两个时间段的数据，永久有效填写9999123199991231 ，只有注册时间请填写注册时间，如果有效时间为区间请以yyyyMMddyyyyMMdd的格式填写两个时间【非图片认证时此参数必填】
        /// </summary>
        public string Expires { get; set; }

        /// <summary>
        /// 有效期终止时间，永久有效或者只有注册时间请填写99991231 【图片认证与非图片认证均可选】与expires是补充作用
        /// </summary>
        public string ExpiresEnd { get; set; }

        /// <summary>
        /// 有效期起始时间 ，长期请填写99991231，只有注册时间请填写注册时间【图片认证与非图片认证均可选】与expires是补充作用
        /// </summary>
        public string ExpiresStart { get; set; }

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
            return "ssdata.dataservice.risk.businesslicense.certify";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("address", this.Address);
            parameters.Add("biz_id", this.BizId);
            parameters.Add("credit_code", this.CreditCode);
            parameters.Add("ent_legal_name", this.EntLegalName);
            parameters.Add("ent_name", this.EntName);
            parameters.Add("expires", this.Expires);
            parameters.Add("expires_end", this.ExpiresEnd);
            parameters.Add("expires_start", this.ExpiresStart);
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
            parameters.Add("ent_pros_pic", this.EntProsPic);
            return parameters;
        }

        #endregion
    }
}
