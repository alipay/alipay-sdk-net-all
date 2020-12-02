using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.agent.common.sign
    /// </summary>
    public class AlipayOpenAgentCommonSignRequest : IAopUploadRequest<AlipayOpenAgentCommonSignResponse>
    {
        /// <summary>
        /// 支付宝生活号(原服务窗)名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string AlipayLifeName { get; set; }

        /// <summary>
        /// APP demo，格式为.apk；或者应用说明文档, 格式为.doc .docx .pdf格式（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public FileItem AppDemo { get; set; }

        /// <summary>
        /// 商户的APP应用名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.agent.create接口进行创建。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
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
        /// <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.59bgD2&treeId=222&articleId=105364&docType=1#s1">商家经营类目</a> 中的“经营类目编码”
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// isv要代商户签约产品码，产品码是支付宝内部对产品的唯一标识
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 店铺内景图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考 <a href="https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.59bgD2&treeId=222&articleId=105364&docType=1#s1">商家经营类目</a> 中的“需要的特殊资质证书”，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

        /// <summary>
        /// 网站首页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem WebHomeScreenshot { get; set; }

        /// <summary>
        /// 网站商品页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem WebItemScreenshot { get; set; }

        /// <summary>
        /// 网站支付页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem WebPayScreenshot { get; set; }

        /// <summary>
        /// 接入网址信息（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public List<string> WebSites { get; set; }

        /// <summary>
        /// 接入网址的授权涵，格式为.doc .docx .pdf格式
        /// </summary>
        public FileItem WebSitesLoa { get; set; }

        /// <summary>
        /// 网站状态，枚举值为：已上线，未上线
        /// </summary>
        public string WebStatus { get; set; }

        /// <summary>
        /// 可以登录此网站的测试账户
        /// </summary>
        public string WebTestAccount { get; set; }

        /// <summary>
        /// 可以登录此网站的账户的密码。对应web_test_account的登录密码
        /// </summary>
        public string WebTestAccountPassword { get; set; }

        /// <summary>
        /// 微信公众号名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string WechatOfficialAccountName { get; set; }

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
            return "alipay.open.agent.common.sign";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_life_name", this.AlipayLifeName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("batch_no", this.BatchNo);
            parameters.Add("business_license_no", this.BusinessLicenseNo);
            parameters.Add("date_limitation", this.DateLimitation);
            parameters.Add("long_term", this.LongTerm);
            parameters.Add("mcc_code", this.MccCode);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("web_sites", this.WebSites);
            parameters.Add("web_status", this.WebStatus);
            parameters.Add("web_test_account", this.WebTestAccount);
            parameters.Add("web_test_account_password", this.WebTestAccountPassword);
            parameters.Add("wechat_official_account_name", this.WechatOfficialAccountName);
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
            parameters.Add("app_demo", this.AppDemo);
            parameters.Add("business_license_auth_pic", this.BusinessLicenseAuthPic);
            parameters.Add("business_license_pic", this.BusinessLicensePic);
            parameters.Add("shop_scene_pic", this.ShopScenePic);
            parameters.Add("shop_sign_board_pic", this.ShopSignBoardPic);
            parameters.Add("special_license_pic", this.SpecialLicensePic);
            parameters.Add("web_home_screenshot", this.WebHomeScreenshot);
            parameters.Add("web_item_screenshot", this.WebItemScreenshot);
            parameters.Add("web_pay_screenshot", this.WebPayScreenshot);
            parameters.Add("web_sites_loa", this.WebSitesLoa);
            return parameters;
        }

        #endregion
    }
}
