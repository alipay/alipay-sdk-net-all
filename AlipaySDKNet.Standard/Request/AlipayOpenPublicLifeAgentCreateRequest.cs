using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.life.agent.create
    /// </summary>
    public class AlipayOpenPublicLifeAgentCreateRequest : IAopUploadRequest<AlipayOpenPublicLifeAgentCreateResponse>
    {
        /// <summary>
        /// 服务商代开通生活号的商户支付宝账号或商户支付宝账号 pid（2088开头16位长度的字符串）。 注意：账号需通过 <a href="https://opendocs.alipay.com/open/200/qyzfbsmrz">实名认证</a>。
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 生活号背景图片
        /// </summary>
        public FileItem BackgroundPic { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照号码。被代创建商户运营主体为个人账户必填，企业账户无需填写
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// 生活号头像
        /// </summary>
        public FileItem LogoPic { get; set; }

        /// <summary>
        /// 所属MCCCode，详情可参考<a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a>中的“类目code”。
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 外部入驻申请单据号，由开发者自行生成，并需保证在开发者端不重复。 注意：如果代创建申请被驳回，需更换新的申请号，原申请号不能再次使用。
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 自有知识产权证书图片
        /// </summary>
        public FileItem OwnIntellectualPic { get; set; }

        /// <summary>
        /// 生活号简介
        /// </summary>
        public string PublicDesc { get; set; }

        /// <summary>
        /// 生活号名称
        /// </summary>
        public string PublicName { get; set; }

        /// <summary>
        /// 店铺内景图片，被代创建商户运营主体为个人账户必填，企业账户选填
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，被代创建商户运营主体为个人账户必填，企业账户选填
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考<a href="https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE">商家经营类目</a>中的 “所需资质”。
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
            return "alipay.open.public.life.agent.create";
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
            parameters.Add("account", this.Account);
            parameters.Add("business_license_no", this.BusinessLicenseNo);
            parameters.Add("contact_email", this.ContactEmail);
            parameters.Add("contact_mobile", this.ContactMobile);
            parameters.Add("contact_name", this.ContactName);
            parameters.Add("mcc_code", this.MccCode);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("public_desc", this.PublicDesc);
            parameters.Add("public_name", this.PublicName);
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
            parameters.Add("background_pic", this.BackgroundPic);
            parameters.Add("business_license_auth_pic", this.BusinessLicenseAuthPic);
            parameters.Add("business_license_pic", this.BusinessLicensePic);
            parameters.Add("logo_pic", this.LogoPic);
            parameters.Add("own_intellectual_pic", this.OwnIntellectualPic);
            parameters.Add("shop_scene_pic", this.ShopScenePic);
            parameters.Add("shop_sign_board_pic", this.ShopSignBoardPic);
            parameters.Add("special_license_pic", this.SpecialLicensePic);
            return parameters;
        }

        #endregion
    }
}
