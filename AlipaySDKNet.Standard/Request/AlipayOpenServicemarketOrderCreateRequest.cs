using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.servicemarket.order.create
    /// </summary>
    public class AlipayOpenServicemarketOrderCreateRequest : IAopUploadRequest<AlipayOpenServicemarketOrderCreateResponse>
    {
        /// <summary>
        /// 11_12;12_13。小程序类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目，详细类目可以参考https://docs.alipay.com/isv/10325
        /// </summary>
        public string AppCategoryIds { get; set; }

        /// <summary>
        /// 小程序官方示例Demo，展示已支持的接口能力及组件。
        /// </summary>
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标，图片格式必须为：png、jpeg、jpg，建议上传像素为180*180
        /// </summary>
        public FileItem AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 来源的业务方，需要申请
        /// </summary>
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        public string AppSlogan { get; set; }

        /// <summary>
        /// 订购的服务商品ID所在的市场编码。新接入场景必须传递，具体值请联系产品分配。
        /// </summary>
        public string MarketCode { get; set; }

        /// <summary>
        /// 订购的服务商品ID
        /// </summary>
        public string MerchandiseId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        public string MerchantPid { get; set; }

        /// <summary>
        /// 一二方支持传入appId
        /// </summary>
        public string MiniAppId { get; set; }

        /// <summary>
        /// 新小程序前台类目，格式为 第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目_第二个三级类目，详细类目可以通过 https://docs.open.alipay.com/api_49/alipay.open.mini.category.query接口查询mini_category_list，如果不填默认采用当前小程序应用类目。使用默认应用类目后不需要再次上传营业执照号、营业执照名、营业执照截图、营业执照有效期。使用后不再读取app_category_ids值，老前台类目将废弃
        /// </summary>
        public string MiniCategoryIds { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        public string ServicePhone { get; set; }

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
            return "alipay.open.servicemarket.order.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("app_category_ids", this.AppCategoryIds);
            parameters.Add("app_desc", this.AppDesc);
            parameters.Add("app_english_name", this.AppEnglishName);
            parameters.Add("app_name", this.AppName);
            parameters.Add("app_origin", this.AppOrigin);
            parameters.Add("app_slogan", this.AppSlogan);
            parameters.Add("market_code", this.MarketCode);
            parameters.Add("merchandise_id", this.MerchandiseId);
            parameters.Add("merchant_pid", this.MerchantPid);
            parameters.Add("mini_app_id", this.MiniAppId);
            parameters.Add("mini_category_ids", this.MiniCategoryIds);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("service_email", this.ServiceEmail);
            parameters.Add("service_phone", this.ServicePhone);
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
            parameters.Add("app_logo", this.AppLogo);
            return parameters;
        }

        #endregion
    }
}
