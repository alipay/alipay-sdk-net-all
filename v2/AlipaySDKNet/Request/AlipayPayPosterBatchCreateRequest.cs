using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pay.poster.batch.create
    /// </summary>
    public class AlipayPayPosterBatchCreateRequest : IAopUploadRequest<AlipayPayPosterBatchCreateResponse>
    {
        /// <summary>
        /// 投放设备范围文件，和device_ids二选一即可
        /// </summary>
        public FileItem DeviceFile { get; set; }

        /// <summary>
        /// 设备id集合，和文件二选一即可
        /// </summary>
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 海报投放结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 图片文件地址
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 货柜对应的商家id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 编辑操作人
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 活动投放名称
        /// </summary>
        public string PosterName { get; set; }

        /// <summary>
        /// 活动投放开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

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
            return "alipay.pay.poster.batch.create";
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
            parameters.Add("device_ids", this.DeviceIds);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("img_url", this.ImgUrl);
            parameters.Add("merchant_id", this.MerchantId);
            parameters.Add("operator", this.Operator);
            parameters.Add("poster_name", this.PosterName);
            parameters.Add("start_time", this.StartTime);
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
            parameters.Add("device_file", this.DeviceFile);
            return parameters;
        }

        #endregion
    }
}
