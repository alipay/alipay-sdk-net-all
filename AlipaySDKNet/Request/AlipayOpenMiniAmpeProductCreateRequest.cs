using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.mini.ampe.product.create
    /// </summary>
    public class AlipayOpenMiniAmpeProductCreateRequest : IAopUploadRequest<AlipayOpenMiniAmpeProductCreateResponse>
    {
        /// <summary>
        /// 行业类目
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备产品名称, 必填，最大长度32，单oid下唯一
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 产品图片二进制流，必填，最小为1k，最大不能超过5MB，图片格式只支持jpg，png
        /// </summary>
        public FileItem ProductPic { get; set; }

        /// <summary>
        /// 场景码，申请后平台分配
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 出货量
        /// </summary>
        public Nullable<long> ShipQuantity { get; set; }

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
            return "alipay.open.mini.ampe.product.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("device_type", this.DeviceType);
            parameters.Add("product_name", this.ProductName);
            parameters.Add("scene_code", this.SceneCode);
            parameters.Add("ship_quantity", this.ShipQuantity);
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
            parameters.Add("product_pic", this.ProductPic);
            return parameters;
        }

        #endregion
    }
}
