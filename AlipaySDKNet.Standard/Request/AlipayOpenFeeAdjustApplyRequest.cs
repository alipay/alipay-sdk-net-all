using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.fee.adjust.apply
    /// </summary>
    public class AlipayOpenFeeAdjustApplyRequest : IAopUploadRequest<AlipayOpenFeeAdjustApplyResponse>
    {
        /// <summary>
        /// 服务商代申请特殊费率的商家支付宝账户
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 服务商代商家申请特殊费率的费率值（%），如0.38表示0.38%
        /// </summary>
        public string ApplicationFee { get; set; }

        /// <summary>
        /// 其他支付方式费率证明或者业务补充说明，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem Attachment { get; set; }

        /// <summary>
        /// 对应证件类型（certType）的证件号，如营业执照为营业执照号
        /// </summary>
        public string CertNo { get; set; }

        /// <summary>
        /// 对应证件的图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem CertPic { get; set; }

        /// <summary>
        /// 证件类型，枚举值为 餐饮服务许可证 FOOD_SERVICE_LICENSE， 食品卫生许可证 FOOD_HEALTH_LICENSE， 食品经营许可证 FOOD_BUSINESS_LICENSE， 食品流通许可证 FOOD_CIRCULATE_LICENSE， 食品生产许可证 FOOD_PRODUCTION_LICENS， 营业执照     DEFAULT_LICENSE， 烟草资质 TOBACCO_PRODUCTION_LICENSE
        /// </summary>
        public string CertType { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区/县
        /// </summary>
        public string DistrictCode { get; set; }

        /// <summary>
        /// 服务商代商家申请调整费率的产品码
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 店铺内景图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片，最小5KB，图片格式必须为：png、bmp、gif、jpg、jpeg
        /// </summary>
        public FileItem ShopSignPic { get; set; }

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
            return "alipay.open.fee.adjust.apply";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("account", this.Account);
            parameters.Add("application_fee", this.ApplicationFee);
            parameters.Add("cert_no", this.CertNo);
            parameters.Add("cert_type", this.CertType);
            parameters.Add("city_code", this.CityCode);
            parameters.Add("detail_address", this.DetailAddress);
            parameters.Add("district_code", this.DistrictCode);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("province_code", this.ProvinceCode);
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
            parameters.Add("attachment", this.Attachment);
            parameters.Add("cert_pic", this.CertPic);
            parameters.Add("shop_scene_pic", this.ShopScenePic);
            parameters.Add("shop_sign_pic", this.ShopSignPic);
            return parameters;
        }

        #endregion
    }
}
