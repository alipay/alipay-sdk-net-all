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
        /// 支付宝生活号(原服务窗)名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name。1、2、3少选择一个填写）
        /// </summary>
        public string AlipayLifeName { get; set; }

        /// <summary>
        /// APP授权函图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppAuthPic { get; set; }

        /// <summary>
        /// APP demo，格式为.apk；或者应用说明文档, 格式为.doc .docx .pdf格式（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public FileItem AppDemo { get; set; }

        /// <summary>
        /// 应用首页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppHomeScreenshot { get; set; }

        /// <summary>
        /// 商品或服务页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppItemScreenshot { get; set; }

        /// <summary>
        /// 投放应用市场
        /// </summary>
        public string AppMarket { get; set; }

        /// <summary>
        /// 商户的APP应用名称（1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写）
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 应用内支付页截图，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem AppPayScreenshot { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        public string AppStatus { get; set; }

        /// <summary>
        /// 可以登录该应用的测试账户
        /// </summary>
        public string AppTestAccount { get; set; }

        /// <summary>
        /// 可以登录此应用的账户的密码。对app_test_account的登录密码。
        /// </summary>
        public string AppTestAccountPassword { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.agent.create接口进行创建。
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照授权函图片，个体工商户如果使用总公司或其他公司的营业执照认证需上传该授权函图片，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业执照图片。被代创建商户运营主体为个人账户必填，企业账户无需填写。图片最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。
        /// </summary>
        public FileItem BusinessLicensePic { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        public string DateLimitation { get; set; }

        /// <summary>
        /// 应用下载链接
        /// </summary>
        public string DownloadLink { get; set; }

        /// <summary>
        /// 网站备注图片
        /// </summary>
        public FileItem H5ExtraPic { get; set; }

        /// <summary>
        /// H5网站首页截图
        /// </summary>
        public FileItem H5HomeScreenshot { get; set; }

        /// <summary>
        /// H5网站商品截图
        /// </summary>
        public FileItem H5ItemScreenshot { get; set; }

        /// <summary>
        /// 网站扩展信息文本
        /// </summary>
        public string H5Memo { get; set; }

        /// <summary>
        /// H5网站支付页截图
        /// </summary>
        public FileItem H5PayScreenshot { get; set; }

        /// <summary>
        /// H5网站地址
        /// </summary>
        public string H5Sites { get; set; }

        /// <summary>
        /// H5网站授权函
        /// </summary>
        public FileItem H5SitesLoa { get; set; }

        /// <summary>
        /// H5网站状态
        /// </summary>
        public string H5Status { get; set; }

        /// <summary>
        /// 请输入被签约商户的支付宝生活号ID编号
        /// </summary>
        public string LifeAppId { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        public Nullable<bool> LongTerm { get; set; }

        /// <summary>
        /// <a href="https://opendocs.alipay.com/common/02khjv">商家经营类目</a> 中的“经营类目编码”
        /// </summary>
        public string MccCode { get; set; }

        /// <summary>
        /// 请输入被签约商家下任意小程序APPID ID编号
        /// </summary>
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        public string MiniAppName { get; set; }

        /// <summary>
        /// 请上传商家小程序截图信息，最小5KB ，最大5M（暂不限制图片宽高），图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem MiniAppScreenshot { get; set; }

        /// <summary>
        /// 移动设备类型，当开通电脑网站支付产品时不需赋值；当开通手机网站支付时，传H5；当开通JSAPI时，传APP；当开通预授权支付产品，且交易场景选择“mobile”(移动设备)时，需要从APP,H5中至少选择一个，可多选，字符串英文逗号分隔。
        /// </summary>
        public string MobileType { get; set; }

        /// <summary>
        /// isv要代商户签约产品码，产品码是支付宝内部对产品的唯一标识
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 服务费率（%），例如：请输入0.38~0.6 之间（小数点后两位，可取0.38%及0.6%），直播买卖通涉及JSAPI支付产品，交易手续费为 0.38%-0.6%，后续费率变化可参考支付宝标准服务费。 当签约且授权标识 sign_and_auth=true 时，该费率信息必填。
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// 门店所在城市
        /// </summary>
        public string ShopCityCode { get; set; }

        /// <summary>
        /// 门店详细地址
        /// </summary>
        public string ShopDetailAddress { get; set; }

        /// <summary>
        /// 门店所在区/县
        /// </summary>
        public string ShopDistrictCode { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 门店所在省份
        /// </summary>
        public string ShopProvinceCode { get; set; }

        /// <summary>
        /// 店铺内景图片，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg。
        /// </summary>
        public FileItem ShopSignBoardPic { get; set; }

        /// <summary>
        /// 企业特殊资质图片，可参考 <a href="https://opendocs.alipay.com/common/02khjv">商家经营类目</a> 中的“需要的特殊资质证书”。文件最小为 5KB，最大为5M，图片格式必须为：png、bmp、gif、jpg、jpeg。
        /// </summary>
        public FileItem SpecialLicensePic { get; set; }

        /// <summary>
        /// 合约特殊资质的类型，不传默认99
        /// </summary>
        public string SpecialLicenseType { get; set; }

        /// <summary>
        /// 交易场景，当开通产品为电脑网站支付时，传pc；当开通产品为手机网站支付时，传mobile；当开通产品为JSAPI时，传tiny_app；当开通产品为预授权支付时，下面括号中三个至少传一个（tiny_app,mobile,offline_store），可多选，字符串用英文逗号分隔
        /// </summary>
        public string TradeScene { get; set; }

        /// <summary>
        /// 网站首页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem WebHomeScreenshot { get; set; }

        /// <summary>
        /// 网站商品页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem WebItemScreenshot { get; set; }

        /// <summary>
        /// 网站支付页截图，最小5KB，最大5M，图片格式必须为：png、bmp、gif、jpg、jpeg
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
        /// 网站状态，枚举值为：ONLINE，OFFLINE
        /// </summary>
        public string WebStatus { get; set; }

        /// <summary>
        /// 可以登录此网站的测试账户。
        /// </summary>
        public string WebTestAccount { get; set; }

        /// <summary>
        /// 可以登录此网站的账户的密码。对应web_test_account的登录密码
        /// </summary>
        public string WebTestAccountPassword { get; set; }

        /// <summary>
        /// 1 app_name、app_demo；2 web_sites；3 alipay_life_name；4 wechat_official_account_name。1、2、3、4至少选择一个填写
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
            return "alipay.open.agent.common.sign";
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
            parameters.Add("alipay_life_name", this.AlipayLifeName);
            parameters.Add("app_market", this.AppMarket);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_status", this.AppStatus);
            parameters.Add("app_test_account", this.AppTestAccount);
            parameters.Add("app_test_account_password", this.AppTestAccountPassword);
            parameters.Add("batch_no", this.BatchNo);
            parameters.Add("business_license_no", this.BusinessLicenseNo);
            parameters.Add("date_limitation", this.DateLimitation);
            parameters.Add("download_link", this.DownloadLink);
            parameters.Add("h_5_memo", this.H5Memo);
            parameters.Add("h_5_sites", this.H5Sites);
            parameters.Add("h_5_status", this.H5Status);
            parameters.Add("life_app_id", this.LifeAppId);
            parameters.Add("long_term", this.LongTerm);
            parameters.Add("mcc_code", this.MccCode);
            parameters.Add("mini_app_id", this.MiniAppId);
            parameters.Add("mini_app_name", this.MiniAppName);
            parameters.Add("mobile_type", this.MobileType);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("rate", this.Rate);
            parameters.Add("shop_city_code", this.ShopCityCode);
            parameters.Add("shop_detail_address", this.ShopDetailAddress);
            parameters.Add("shop_district_code", this.ShopDistrictCode);
            parameters.Add("shop_name", this.ShopName);
            parameters.Add("shop_province_code", this.ShopProvinceCode);
            parameters.Add("special_license_type", this.SpecialLicenseType);
            parameters.Add("trade_scene", this.TradeScene);
            parameters.Add("web_sites", this.WebSites);
            parameters.Add("web_status", this.WebStatus);
            parameters.Add("web_test_account", this.WebTestAccount);
            parameters.Add("web_test_account_password", this.WebTestAccountPassword);
            parameters.Add("wechat_official_account_name", this.WechatOfficialAccountName);
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
            parameters.Add("app_auth_pic", this.AppAuthPic);
            parameters.Add("app_demo", this.AppDemo);
            parameters.Add("app_home_screenshot", this.AppHomeScreenshot);
            parameters.Add("app_item_screenshot", this.AppItemScreenshot);
            parameters.Add("app_pay_screenshot", this.AppPayScreenshot);
            parameters.Add("business_license_auth_pic", this.BusinessLicenseAuthPic);
            parameters.Add("business_license_pic", this.BusinessLicensePic);
            parameters.Add("h_5_extra_pic", this.H5ExtraPic);
            parameters.Add("h_5_home_screenshot", this.H5HomeScreenshot);
            parameters.Add("h_5_item_screenshot", this.H5ItemScreenshot);
            parameters.Add("h_5_pay_screenshot", this.H5PayScreenshot);
            parameters.Add("h_5_sites_loa", this.H5SitesLoa);
            parameters.Add("mini_app_screenshot", this.MiniAppScreenshot);
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
