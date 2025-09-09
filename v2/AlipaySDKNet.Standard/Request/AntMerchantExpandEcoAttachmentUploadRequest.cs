using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ant.merchant.expand.eco.attachment.upload
    /// </summary>
    public class AntMerchantExpandEcoAttachmentUploadRequest : IAopUploadRequest<AntMerchantExpandEcoAttachmentUploadResponse>
    {
        /// <summary>
        /// 附件的业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 外部平台编号
        /// </summary>
        public string BusiPlatform { get; set; }

        /// <summary>
        /// 文件内容，以文件流形式进行传输
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文档格式
        /// </summary>
        public string FileFormat { get; set; }

        /// <summary>
        /// 附件单据号（必填）订单号 (out_order_id)
        /// </summary>
        public string OutOrderId { get; set; }

        /// <summary>
        /// 图片序号，多个文件上传时，part_no按照0,1,2...递增（必填）
        /// </summary>
        public string PartNo { get; set; }

        /// <summary>
        /// 码图片附件
        /// </summary>
        public string SubBizType { get; set; }

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
            return "ant.merchant.expand.eco.attachment.upload";
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
            parameters.Add("biz_type", this.BizType);
            parameters.Add("busi_platform", this.BusiPlatform);
            parameters.Add("file_format", this.FileFormat);
            parameters.Add("out_order_id", this.OutOrderId);
            parameters.Add("part_no", this.PartNo);
            parameters.Add("sub_biz_type", this.SubBizType);
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
