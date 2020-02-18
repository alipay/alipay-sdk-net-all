using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ins.scene.claim.attachment.upload
    /// </summary>
    public class AlipayInsSceneClaimAttachmentUploadRequest : IAopUploadRequest<AlipayInsSceneClaimAttachmentUploadResponse>
    {
        /// <summary>
        /// 案件材料名称
        /// </summary>
        public string AttachmentName { get; set; }

        /// <summary>
        /// 附件材料类型  现场照片：SCENE_PHOTO  身份证影印件： ID_COPY  发票： INVOICE  医疗凭证： MEDICAL_CERTIFICATE
        /// </summary>
        public string AttachmentType { get; set; }

        /// <summary>
        /// 理赔申请报案号，通过理赔申请【alipay.ins.scene.claim.apply】接口的返回字段claim_report_no获取
        /// </summary>
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 报案材料描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 报案材料内容
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 案件材料文件类型  例如一下值   .jpg .png .csv .docx
        /// </summary>
        public string FileType { get; set; }

        #region IAopRequest Members
		private bool needEncrypt=false;
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

		public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public string GetApiName()
        {
            return "alipay.ins.scene.claim.attachment.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("attachment_name", this.AttachmentName);
            parameters.Add("attachment_type", this.AttachmentType);
            parameters.Add("claim_report_no", this.ClaimReportNo);
            parameters.Add("description", this.Description);
            parameters.Add("file_type", this.FileType);
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
