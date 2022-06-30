using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.material.image.upload
    /// </summary>
    public class AlipayMarketingMaterialImageUploadRequest : IAopUploadRequest<AlipayMarketingMaterialImageUploadResponse>
    {
        /// <summary>
        /// 服务商代商户创建投放必选 bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 图片的byte字节数组。图片大小限制为2M
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文件业务标识。  枚举值 alipay.marketing.activity.delivery.create接口中 delivery_base_info.delivery_material.delivery_single_material.delivery_image 当delivery_booth_code=PUBLIC_UNION，上传图片接口需指定file_key=PUBLIC_UNION_CHANNEL_PIC。上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过200kb； 当delivery_booth_code=PAYMENT_RESULT，上传图片接口需指定file_key=DELIVERY_CHANNEL_PIC。上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过200kb。 上传图片更多要求参考文档： https://render.alipay.com/p/c/18tpirlg12e8?operateFrom=BALIPAY  alipay.marketing.activity.ordervoucher.create接口中 voucher_display_info.brand_logo字段,file_key=PROMO_BRAND_LOGO，上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB voucher_display_info.voucher_image字段,file_key=PROMO_VOUCHER_IMAGE,上传图片尺寸670*335，支持格式：png、jpg、jpeg、bmp，大小不超过2MB
        /// </summary>
        public string FileKey { get; set; }

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
            return "alipay.marketing.material.image.upload";
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
            parameters.Add("belong_merchant_info", this.BelongMerchantInfo);
            parameters.Add("file_key", this.FileKey);
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
