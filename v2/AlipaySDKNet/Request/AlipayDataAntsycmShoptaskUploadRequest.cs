using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.antsycm.shoptask.upload
    /// </summary>
    public class AlipayDataAntsycmShoptaskUploadRequest : IAopUploadRequest<AlipayDataAntsycmShoptaskUploadResponse>
    {
        /// <summary>
        /// 商户品牌，默认填写不指定。 值有： 1、不指定 2、卡士 3、三得利
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 商户授权码
        /// </summary>
        public string BusinessCode { get; set; }

        /// <summary>
        /// 见<a href="https://opendocs.alipay.com/pre-open/0c07mb">品类维表</a>，依照场景需求使用
        /// </summary>
        public List<string> Category { get; set; }

        /// <summary>
        /// 品类价格
        /// </summary>
        public List<CategoryRangeInfoDTO> CategoryRange { get; set; }

        /// <summary>
        /// 文件流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 见<a href = "https://opendocs.alipay.com/pre-open/0bue7u">省市区信息表</a>，依照场景需求使用
        /// </summary>
        public List<ShopAreaInfoDTO> MarketArea { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string PartnerId { get; set; }

        /// <summary>
        /// 对应更新周期，每（周/月）N更新； once：无值要求； day：无值要求； week：周日=1，周六=7； month：1-31
        /// </summary>
        public Nullable<long> ScheduleTime { get; set; }

        /// <summary>
        /// 更新周期
        /// </summary>
        public string ScheduleType { get; set; }

        /// <summary>
        /// 见<a href = "https://opendocs.alipay.com/pre-open/0bjxu7">行业信息表</a>， 依照场景需求使用
        /// </summary>
        public List<ShopIndustryInfoDTO> ShopIndustry { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        public string TaskType { get; set; }

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
            return "alipay.data.antsycm.shoptask.upload";
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
            parameters.Add("brand_name", this.BrandName);
            parameters.Add("business_code", this.BusinessCode);
            parameters.Add("category", this.Category);
            parameters.Add("category_range", this.CategoryRange);
            parameters.Add("market_area", this.MarketArea);
            parameters.Add("partner_id", this.PartnerId);
            parameters.Add("schedule_time", this.ScheduleTime);
            parameters.Add("schedule_type", this.ScheduleType);
            parameters.Add("shop_industry", this.ShopIndustry);
            parameters.Add("task_name", this.TaskName);
            parameters.Add("task_type", this.TaskType);
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
