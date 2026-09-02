using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: xinghe.lendassist.carfin.repayment.notify
    /// </summary>
    public class XingheLendassistCarfinRepaymentNotifyRequest : IAopRequest<XingheLendassistCarfinRepaymentNotifyResponse>
    {
        /// <summary>
        /// 机构在还款处理完成后(还款成功或失败),主动调用该接口将还款结果通知星河车金融,包含还款方式、 还款状态、是否退款、还款失败原因等信息。星河侧受理后返回成功与否,无业务出参。本接口同时支持增量地在机构侧还款记录同步:通过 notify_type 区分通知类型。当 notify_type为「机构侧还款通知」时,机构需在还款计划同步报文中通知实还的借据号及各项实还金额(实还本金、实还利息、实还罚息等),星河侧据此增量更新还款记录。
        /// </summary>
        public string BizContent { get; set; }

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
            return "xinghe.lendassist.carfin.repayment.notify";
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
            parameters.Add("biz_content", this.BizContent);
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
