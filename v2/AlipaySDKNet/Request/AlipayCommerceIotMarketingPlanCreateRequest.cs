using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.iot.marketing.plan.create
    /// </summary>
    public class AlipayCommerceIotMarketingPlanCreateRequest : IAopUploadRequest<AlipayCommerceIotMarketingPlanCreateResponse>
    {
        /// <summary>
        /// 投放设备bizTid列表,服务商所有的设备，取设备的bizTid 多个bizTid示例：["010100q0jl5X4o8LZQWAOUxu6GcrtPl4wR68wQerXVACt5EAaQISk4k","010100q0iZ5XP3eiSA25lhlyGq8dxPMOHe8Ae4s1BGptXegHN3fCQ1g"]
        /// </summary>
        public List<string> BizTids { get; set; }

        /// <summary>
        /// 投放计划结束时间戳
        /// </summary>
        public Nullable<long> EndTime { get; set; }

        /// <summary>
        /// 海报投放图片  电子海报投放可投3张 ,一次只能投一张，第二次追加 上限3张后续会进行覆盖  支付结果页投放。只能投放1张图片 取file_content_1字段
        /// </summary>
        public FileItem FileContent1 { get; set; }

        /// <summary>
        /// 图片1横屏竖屏配置   HORIZONTAL_SCREEN(1, "横屏"),     VERTICAL_SCREEN(2, "竖屏")
        /// </summary>
        public Nullable<long> HvScreen1 { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 投放计划优先级
        /// </summary>
        public Nullable<long> Priority { get; set; }

        /// <summary>
        /// NORMAL_DISPLAY---电子海报,  可投3张图片，一次投一张，第二次追加，上限3张。后续投放会进行覆盖  PAY_SUCCESS_RESULT---支付结果页。只能投放1张图片 MERCHANT_INFO_POSTER---商户信息海报
        /// </summary>
        public string SpaceCode { get; set; }

        /// <summary>
        /// 投放计划开始时间戳
        /// </summary>
        public Nullable<long> StartTime { get; set; }

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
            return "alipay.commerce.iot.marketing.plan.create";
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
            parameters.Add("biz_tids", this.BizTids);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("hv_screen_1", this.HvScreen1);
            parameters.Add("plan_name", this.PlanName);
            parameters.Add("priority", this.Priority);
            parameters.Add("space_code", this.SpaceCode);
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
            parameters.Add("file_content_1", this.FileContent1);
            return parameters;
        }

        #endregion
    }
}
