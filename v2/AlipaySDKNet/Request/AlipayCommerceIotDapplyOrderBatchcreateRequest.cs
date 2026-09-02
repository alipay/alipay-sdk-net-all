using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.iot.dapply.order.batchcreate
    /// </summary>
    public class AlipayCommerceIotDapplyOrderBatchcreateRequest : IAopUploadRequest<AlipayCommerceIotDapplyOrderBatchcreateResponse>
    {
        /// <summary>
        /// 申请人的手机号
        /// </summary>
        public string ApplicantMobile { get; set; }

        /// <summary>
        /// 自定义申请人名称，不作业务校验
        /// </summary>
        public string ApplicantName { get; set; }

        /// <summary>
        /// 如果是商户需要传MERCHANTPORTAL，如果是服务商需要传ISV
        /// </summary>
        public string ChannelCode { get; set; }

        /// <summary>
        /// 批量申请时excel文件内容，将文件内容转成字节流传入
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 设备ItemId（物料ID），首次接入时需要咨询业务经理进行获取
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 商品ID，首次接入时请咨询业务经理进行获取
        /// </summary>
        public string MallItemId { get; set; }

        /// <summary>
        /// 订单备注，业务根据自己的场景进行备注信息，可通过订单详情返回
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务流水号(作为请求幂等号)
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 人工操作对应平台为商家中心(b.alipay.com)时填MERCHANTPORTAL，服务商平台(p.alipay.com)时填ISV
        /// </summary>
        public string SourceCode { get; set; }

        /// <summary>
        /// 支架配件商品ID，首次接入时需要咨询业务经理进行获取
        /// </summary>
        public string SupportMallItemId { get; set; }

        /// <summary>
        /// 批量申请总的设备数量，必须和文件里面的申请数量总和一致
        /// </summary>
        public Nullable<long> TotalApplyAmount { get; set; }

        /// <summary>
        /// 批量申请的条目数，必须和文件对应的条目数(去除表头）一致。
        /// </summary>
        public Nullable<long> TotalApplyCount { get; set; }

        /// <summary>
        /// USB配件商品对应的MallItemId(MI),首次接入时需咨询业务经理进行获取
        /// </summary>
        public string UsbMallItemId { get; set; }

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
            return "alipay.commerce.iot.dapply.order.batchcreate";
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
            parameters.Add("applicant_mobile", this.ApplicantMobile);
            parameters.Add("applicant_name", this.ApplicantName);
            parameters.Add("channel_code", this.ChannelCode);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("mall_item_id", this.MallItemId);
            parameters.Add("memo", this.Memo);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("source_code", this.SourceCode);
            parameters.Add("support_mall_item_id", this.SupportMallItemId);
            parameters.Add("total_apply_amount", this.TotalApplyAmount);
            parameters.Add("total_apply_count", this.TotalApplyCount);
            parameters.Add("usb_mall_item_id", this.UsbMallItemId);
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
