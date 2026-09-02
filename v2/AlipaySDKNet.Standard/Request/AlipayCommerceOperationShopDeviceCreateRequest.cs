using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.operation.shop.device.create
    /// </summary>
    public class AlipayCommerceOperationShopDeviceCreateRequest : IAopUploadRequest<AlipayCommerceOperationShopDeviceCreateResponse>
    {
        /// <summary>
        /// 支付宝行业 MCC 一级编码
        /// </summary>
        public string CategoryL1 { get; set; }

        /// <summary>
        /// 支付宝行业 MCC 二级编码
        /// </summary>
        public string CategoryL2 { get; set; }

        /// <summary>
        /// 地址版本：2022Q2
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 与营业执照一致
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 设备SN/序列号
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备类型以及机型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 地址版本：2022Q2
        /// </summary>
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        public string DistrictName { get; set; }

        /// <summary>
        /// 使用流量币业务时建议传；未传或不正确时，可能影响流量币在闪购门店投放
        /// </summary>
        public string ElemeDdShopId { get; set; }

        /// <summary>
        /// 使用流量币业务时建议传；未传或不正确时，可能影响流量币在闪购门店投放
        /// </summary>
        public string ElemeDdShopName { get; set; }

        /// <summary>
        /// 例如 30.687181
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 法人身份证反面
        /// </summary>
        public FileItem LegalIdentityBack { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd
        /// </summary>
        public string LegalIdentityFromDate { get; set; }

        /// <summary>
        /// 法人身份证正面
        /// </summary>
        public FileItem LegalIdentityFront { get; set; }

        /// <summary>
        /// 店铺法人身份证号
        /// </summary>
        public string LegalIdentityNo { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd
        /// </summary>
        public string LegalIdentityToDate { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照图片
        /// </summary>
        public FileItem LicenseImg { get; set; }

        /// <summary>
        /// 统一社会信用代码/注册号
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 例如 104.104887
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// 门店在服务商系统里的商户名称
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// 门店在服务商系统里的唯一ID
        /// </summary>
        public string OutShopId { get; set; }

        /// <summary>
        /// 地址版本：2022Q2
        /// </summary>
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店形象照，图片二进制流，10M内
        /// </summary>
        public FileItem ShopLogo { get; set; }

        /// <summary>
        /// 门店在服务商系统里的门店名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 门店联系电话
        /// </summary>
        public string ShopPhone { get; set; }

        /// <summary>
        /// 门头照，图片二进制流，10M内
        /// </summary>
        public FileItem ShopPhoto { get; set; }

        /// <summary>
        /// 默认传 physical_store
        /// </summary>
        public string ShopType { get; set; }

        /// <summary>
        /// 设备对应的 SMID，多个时按英文逗号隔开
        /// </summary>
        public string Smids { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd
        /// </summary>
        public string ValidToDate { get; set; }

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
            return "alipay.commerce.operation.shop.device.create";
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
            parameters.Add("category_l_1", this.CategoryL1);
            parameters.Add("category_l_2", this.CategoryL2);
            parameters.Add("city_code", this.CityCode);
            parameters.Add("city_name", this.CityName);
            parameters.Add("company_name", this.CompanyName);
            parameters.Add("device_id", this.DeviceId);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("district_code", this.DistrictCode);
            parameters.Add("district_name", this.DistrictName);
            parameters.Add("eleme_dd_shop_id", this.ElemeDdShopId);
            parameters.Add("eleme_dd_shop_name", this.ElemeDdShopName);
            parameters.Add("latitude", this.Latitude);
            parameters.Add("legal_identity_from_date", this.LegalIdentityFromDate);
            parameters.Add("legal_identity_no", this.LegalIdentityNo);
            parameters.Add("legal_identity_to_date", this.LegalIdentityToDate);
            parameters.Add("legal_name", this.LegalName);
            parameters.Add("license_no", this.LicenseNo);
            parameters.Add("longitude", this.Longitude);
            parameters.Add("merchant_name", this.MerchantName);
            parameters.Add("out_shop_id", this.OutShopId);
            parameters.Add("province_code", this.ProvinceCode);
            parameters.Add("province_name", this.ProvinceName);
            parameters.Add("shop_address", this.ShopAddress);
            parameters.Add("shop_name", this.ShopName);
            parameters.Add("shop_phone", this.ShopPhone);
            parameters.Add("shop_type", this.ShopType);
            parameters.Add("smids", this.Smids);
            parameters.Add("valid_to_date", this.ValidToDate);
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
            parameters.Add("legal_identity_back", this.LegalIdentityBack);
            parameters.Add("legal_identity_front", this.LegalIdentityFront);
            parameters.Add("license_img", this.LicenseImg);
            parameters.Add("shop_logo", this.ShopLogo);
            parameters.Add("shop_photo", this.ShopPhoto);
            return parameters;
        }

        #endregion
    }
}
