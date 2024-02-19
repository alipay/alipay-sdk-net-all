using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.fund.mbpcard.file.upload
    /// </summary>
    public class AlipayFundMbpcardFileUploadRequest : IAopUploadRequest<AlipayFundMbpcardFileUploadResponse>
    {
        /// <summary>
        /// 业务场景，对应不同配置
        /// </summary>
        public string BizScene { get; set; }

        /// <summary>
        /// 二进制字节流，最大为10M
        /// </summary>
        public FileItem ImageContent { get; set; }

        /// <summary>
        /// 待识别的图片标签，不传不做OCR识别 ELEC_ADD_TAX_SIMPLE : 增值税普票-电子版 PAPER_ADD_TAX_SIMPLE：增值税普票-纸质版 PAPER_QUOTA：手撕定额发票
        /// </summary>
        public string ImageOcrTag { get; set; }

        /// <summary>
        /// 文件格式，支持格式：bmp、jpg、jpeg、png、gif、pdf
        /// </summary>
        public string ImageType { get; set; }

        /// <summary>
        /// 产品码，业务特征属性
        /// </summary>
        public string ProductCode { get; set; }

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
            return "alipay.fund.mbpcard.file.upload";
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
            parameters.Add("biz_scene", this.BizScene);
            parameters.Add("image_ocr_tag", this.ImageOcrTag);
            parameters.Add("image_type", this.ImageType);
            parameters.Add("product_code", this.ProductCode);
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
            parameters.Add("image_content", this.ImageContent);
            return parameters;
        }

        #endregion
    }
}
