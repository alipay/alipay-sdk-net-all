using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.agent.facetoface.sign
    /// </summary>
    public class AlipayOpenAgentFacetofaceSignRequest : IAopUploadRequest<AlipayOpenAgentFacetofaceSignResponse>
    {
        /// <summary>
        /// 代商户操作事务编号，通过https://opendocs.alipay.com/apis/api_50/alipay.open.agent.create (开启代商户签约、创建应用事务)接口进行事务创建后获取。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填
        /// </summary>
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// 商家经营类目编码。参见 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目2.0</a> 中的“一级类目code_二级类目code”。
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 服务费率（%），0.38~0.6 之间（小数点后两位，可取0.38%及0.6%）。 当签约且授权标识 sign_and_auth=true 时，该费率信息必填。
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        public SignAddressInfo ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺内景图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，最小5KB，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 签约且授权标识，默认为false，只进行签约操作； 如果设置为true，则表示签约成功后，会自动进行应用授权操作。
        /// </summary>
        public Nullable<bool> SignAndAuth { get; set; }

        /// <summary>
        /// 企业特殊资质图片，当mcc_code为需要特殊资质类目时必填。可参考 <a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a> 中的“所需资质”，最小5KB ，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

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
            return "alipay.open.agent.facetoface.sign";
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
            parameters.Add("batch_no", this.BatchNo);
            parameters.Add("business_license_mobile", this.BusinessLicenseMobile);
            parameters.Add("business_license_no", this.BusinessLicenseNo);
            parameters.Add("date_limitation", this.DateLimitation);
            parameters.Add("long_term", this.LongTerm);
            parameters.Add("mcc_code", this.MccCode);
            parameters.Add("rate", this.Rate);
            parameters.Add("shop_address", this.ShopAddress);
            parameters.Add("shop_name", this.ShopName);
            parameters.Add("sign_and_auth", this.SignAndAuth);
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
            parameters.Add("business_license_auth_pic", this.BusinessLicenseAuthPic);
            parameters.Add("business_license_pic", this.BusinessLicensePic);
            parameters.Add("shop_scene_pic", this.ShopScenePic);
            parameters.Add("shop_sign_board_pic", this.ShopSignBoardPic);
            parameters.Add("special_license_pic", this.SpecialLicensePic);
            return parameters;
        }

        #endregion
    }
}
