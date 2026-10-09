using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.poi.create
    /// </summary>
    public class AlipayOpenMiniPoiCreateRequest : IAopUploadRequest<AlipayOpenMiniPoiCreateResponse>
    {
        /// <summary>
        /// 经营资质号
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem FifthRelatedMaterial { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem FirstRelatedMaterial { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem FourthRelatedMaterial { get; set; }

        /// <summary>
        /// POI的具体地址信息，建议按照：省市区县街道门牌号的顺序精确描述地址
        /// </summary>
        public string PoiAddress { get; set; }

        /// <summary>
        /// 相关主体名称，需要与经营材料上的名称保持一致.若地点的相关资质与小程序账号主体一致，则不用填写
        /// </summary>
        public string RelatedName { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem SecondRelatedMaterial { get; set; }

        /// <summary>
        /// 营业执照，同主体可以不传,最多5张，单张不能超过2M
        /// </summary>
        public FileItem ThirdRelatedMaterial { get; set; }

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
            return "alipay.open.mini.poi.create";
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
            parameters.Add("certificate", this.Certificate);
            parameters.Add("poi_address", this.PoiAddress);
            parameters.Add("related_name", this.RelatedName);
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
            parameters.Add("fifth_related_material", this.FifthRelatedMaterial);
            parameters.Add("first_related_material", this.FirstRelatedMaterial);
            parameters.Add("fourth_related_material", this.FourthRelatedMaterial);
            parameters.Add("second_related_material", this.SecondRelatedMaterial);
            parameters.Add("third_related_material", this.ThirdRelatedMaterial);
            return parameters;
        }

        #endregion
    }
}
