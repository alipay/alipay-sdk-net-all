using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.cloud.cloudbase.saas.max.query
    /// </summary>
    public class AlipayCloudCloudbaseSaasMaxQueryRequest : IAopRequest<AlipayCloudCloudbaseSaasMaxQueryResponse>
    {
        /// <summary>
        /// appid
        /// </summary>
        public string BizAppId { get; set; }

        /// <summary>
        /// 默认值RAW
        /// </summary>
        public string ImageType { get; set; }

        /// <summary>
        /// 图片值，根据图片image_type填写
        /// </summary>
        public string ImageValue { get; set; }

        /// <summary>
        /// 默认可不填，具体版本值咨询模型服务提供者
        /// </summary>
        public string ModelVersion { get; set; }

        /// <summary>
        /// 模型路由规则，默认值UA
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// 模型服务编码，具体值咨询模型服务提供者
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 默认值auto，即不区分正反面
        /// </summary>
        public string Side { get; set; }

        /// <summary>
        /// 模型服务uri，具体值咨询模型服务提供者
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// 是否开启iot，默认false
        /// </summary>
        public Nullable<bool> UseIot { get; set; }

        #region IAopRequest Members
        private bool  needEncrypt=false;
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

        public string GetApiName()
        {
            return "alipay.cloud.cloudbase.saas.max.query";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
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
            parameters.Add("biz_app_id", this.BizAppId);
            parameters.Add("image_type", this.ImageType);
            parameters.Add("image_value", this.ImageValue);
            parameters.Add("model_version", this.ModelVersion);
            parameters.Add("route", this.Route);
            parameters.Add("service_code", this.ServiceCode);
            parameters.Add("side", this.Side);
            parameters.Add("uri", this.Uri);
            parameters.Add("use_iot", this.UseIot);
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
    }
}
