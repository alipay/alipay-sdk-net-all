using System;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ins.scene.insserviceprod.serattachment.upload
    /// </summary>
    public class AlipayInsSceneInsserviceprodSerattachmentUploadRequest : IAopUploadRequest<AlipayInsSceneInsserviceprodSerattachmentUploadResponse>
    {
        /// <summary>
        /// 扩展信息，JSON字符串格式。该接口为通用接口，需要和增值服务中台的开发同学根据不同的业务约定不同的字段。
        /// </summary>
        public string BizData { get; set; }

        /// <summary>
        /// 文件业务码(业务方自定义)
        /// </summary>
        public string FileBizCode { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public FileItem FileContent { get; set; }

        /// <summary>
        /// 文件描述
        /// </summary>
        public string FileDesc { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// 文件大小，对应java里面File的length
        /// </summary>
        public string FileSize { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        public string SerBizNo { get; set; }

        /// <summary>
        /// 服务业务类型
        /// </summary>
        public string SerBizType { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public Nullable<DateTime> UploadTime { get; set; }

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
            return "alipay.ins.scene.insserviceprod.serattachment.upload";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_data", this.BizData);
            parameters.Add("file_biz_code", this.FileBizCode);
            parameters.Add("file_desc", this.FileDesc);
            parameters.Add("file_name", this.FileName);
            parameters.Add("file_path", this.FilePath);
            parameters.Add("file_size", this.FileSize);
            parameters.Add("file_type", this.FileType);
            parameters.Add("out_biz_no", this.OutBizNo);
            parameters.Add("ser_biz_no", this.SerBizNo);
            parameters.Add("ser_biz_type", this.SerBizType);
            parameters.Add("upload_time", this.UploadTime);
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
