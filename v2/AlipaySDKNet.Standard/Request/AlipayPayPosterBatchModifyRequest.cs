using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.pay.poster.batch.modify
    /// </summary>
    public class AlipayPayPosterBatchModifyRequest : IAopUploadRequest<AlipayPayPosterBatchModifyResponse>
    {
        /// <summary>
        /// 用户设备投放范围变更覆盖
        /// </summary>
        public FileItem DeviceFile { get; set; }

        /// <summary>
        /// 编辑操作人
        /// </summary>
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// 海报结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 海报图片链接
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 货柜对应的商家id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 是否进行活动下线
        /// </summary>
        public Nullable<bool> Offline { get; set; }

        /// <summary>
        /// 编辑操作人记录
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 活动计划主键
        /// </summary>
        public Nullable<long> PlanId { get; set; }

        /// <summary>
        /// 开始时间
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
            return "alipay.pay.poster.batch.modify";
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
            parameters.Add("offline", this.Offline);
            parameters.Add("operator", this.Operator);
            parameters.Add("plan_id", this.PlanId);
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
