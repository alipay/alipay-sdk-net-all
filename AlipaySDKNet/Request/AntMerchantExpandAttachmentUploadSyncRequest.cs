using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: ant.merchant.expand.attachment.upload.sync
    /// </summary>
    public class AntMerchantExpandAttachmentUploadSyncRequest : IAopUploadRequest<AntMerchantExpandAttachmentUploadSyncResponse>
    {
        /// <summary>
        /// 附件的业务类型
        /// </summary>
        public string BizType { get; set; }

        /// <summary>
        /// 附属信息，JSON格式
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 文件字节流
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文档静态格式
        /// </summary>
        public string FileFormat { get; set; }

        /// <summary>
        /// 文件链接
        /// </summary>
        public string FileUrl { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 附件单据号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        public Nullable<long> PartNo { get; set; }

        /// <summary>
        /// 附件的业务子类型
        /// </summary>
        public string SubBizType { get; set; }

        /// <summary>
        /// 附件子单据号
        /// </summary>
        public string SubOutBizNo { get; set; }

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
            return "ant.merchant.expand.attachment.upload.sync";
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
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("file_format", this.FileFormat);
            parameters.Add("file_url", this.FileUrl);
            parameters.Add("memo", this.Memo);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("part_no", this.PartNo);
            parameters.Add("sub_biz_type", this.SubBizType);
            parameters.Add("sub_out_biz_no", this.SubOutBizNo);
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
