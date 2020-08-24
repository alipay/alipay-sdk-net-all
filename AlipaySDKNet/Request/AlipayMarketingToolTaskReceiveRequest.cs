using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.tool.task.receive
    /// </summary>
    public class AlipayMarketingToolTaskReceiveRequest : IAopRequest<AlipayMarketingToolTaskReceiveResponse>
    {
        /// <summary>
        /// 当完成任务（send）或者主动领奖（receive）且奖品决策方式为指定奖品决策时，需要传入的奖品ID。
        /// </summary>
        public string SpecificPrizeId { get; set; }

        /// <summary>
        /// 阶段码，signup任务报名，send任务完成，receive主动领取。stagecode需要根据具体任务的不同类型（是否需要主动报名/用户触发还是事件触发）来传参。
        /// </summary>
        public string StageCode { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        public string UserId { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
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

        public string GetApiName()
        {
            return "alipay.marketing.tool.task.receive";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("specific_prize_id", this.SpecificPrizeId);
            parameters.Add("stage_code", this.StageCode);
            parameters.Add("task_id", this.TaskId);
            parameters.Add("user_id", this.UserId);
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
