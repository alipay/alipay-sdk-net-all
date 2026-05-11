using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.marketing.verification.trade.audit
    /// </summary>
    public class AlipayMarketingVerificationTradeAuditRequest : IAopUploadRequest<AlipayMarketingVerificationTradeAuditResponse>
    {
        /// <summary>
        /// 激活照片（3c必填）转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem ActivateContent { get; set; }

        /// <summary>
        /// 支付宝交易号，用于识别交易信息
        /// </summary>
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 审计相关业务信息，若审计结果未提交或未通过，则每次请求覆盖上次业务参数。审计已通过则不允许重新提交。
        /// </summary>
        public string BizInfo { get; set; }

        /// <summary>
        /// 送货清单，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem DeliveryListContent { get; set; }

        /// <summary>
        /// 辅助文件信息，如四码照片，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem EvidentiaryContent { get; set; }

        /// <summary>
        /// 发票信息转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem InvoiceContent { get; set; }

        /// <summary>
        /// 产品送达现场照或自提现场照片（家电必传），转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem OnSiteContent { get; set; }

        /// <summary>
        /// 其他辅助材料1，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem OtherContent1 { get; set; }

        /// <summary>
        /// 其他辅助材料2,转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem OtherContent2 { get; set; }

        /// <summary>
        /// 其他辅助材料3，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem OtherContent3 { get; set; }

        /// <summary>
        /// 其他辅助材料4，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem OtherContent4 { get; set; }

        /// <summary>
        /// 其他辅助材料5，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem OtherContent5 { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 销货清单，转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem SalesListContent { get; set; }

        /// <summary>
        /// 支付宝分配的场景编码，用于识别活动场景及区域等信息
        /// </summary>
        public string SceneCode { get; set; }

        /// <summary>
        /// 机身SN照（家电必传），转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem SnBodyContent { get; set; }

        /// <summary>
        /// 商品SN照转为字节流传递，要求为jpg、jpeg、png格式
        /// </summary>
        public FileItem SnContent { get; set; }

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
            return "alipay.marketing.verification.trade.audit";
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
            parameters.Add("alipay_trade_no", this.AlipayTradeNo);
            parameters.Add("biz_info", this.BizInfo);
            parameters.Add("out_trade_no", this.OutTradeNo);
            parameters.Add("scene_code", this.SceneCode);
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
            parameters.Add("activate_content", this.ActivateContent);
            parameters.Add("delivery_list_content", this.DeliveryListContent);
            parameters.Add("evidentiary_content", this.EvidentiaryContent);
            parameters.Add("invoice_content", this.InvoiceContent);
            parameters.Add("on_site_content", this.OnSiteContent);
            parameters.Add("other_content_1", this.OtherContent1);
            parameters.Add("other_content_2", this.OtherContent2);
            parameters.Add("other_content_3", this.OtherContent3);
            parameters.Add("other_content_4", this.OtherContent4);
            parameters.Add("other_content_5", this.OtherContent5);
            parameters.Add("sales_list_content", this.SalesListContent);
            parameters.Add("sn_body_content", this.SnBodyContent);
            parameters.Add("sn_content", this.SnContent);
            return parameters;
        }

        #endregion
    }
}
