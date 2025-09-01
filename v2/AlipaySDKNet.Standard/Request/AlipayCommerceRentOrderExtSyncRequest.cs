using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;
using Aop.Api.Util;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.rent.order.ext.sync
    /// </summary>
    public class AlipayCommerceRentOrderExtSyncRequest : IAopUploadRequest<AlipayCommerceRentOrderExtSyncResponse>
    {
        /// <summary>
        /// 买家的身份证反面照片
        /// </summary>
        public FileItem BuyerCertBackPic { get; set; }

        /// <summary>
        /// 买家的身份证正面照片
        /// </summary>
        public FileItem BuyerCertFrontPic { get; set; }

        /// <summary>
        /// 买家扩展信息
        /// </summary>
        public SellerSyncRentBuyerExtInfo BuyerExtInfo { get; set; }

        /// <summary>
        /// 买家支付宝用户ID
        /// </summary>
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家的活体检测照片
        /// </summary>
        public FileItem BuyerLivePic { get; set; }

        /// <summary>
        /// 买家支付宝OPENID
        /// </summary>
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 物流扩展信息
        /// </summary>
        public SellerSyncRentDeliveryExtInfo DeliveryExtInfo { get; set; }

        /// <summary>
        /// 收货确认图片
        /// </summary>
        public FileItem DeliveryReceivedPic { get; set; }

        /// <summary>
        /// null
        /// </summary>
        public List<SellerSyncRentFinancingExtInfo> FinancingExtInfo { get; set; }

        /// <summary>
        /// 租赁协议
        /// </summary>
        public FileItem FinancingRentProtocol { get; set; }

        /// <summary>
        /// 首租信息
        /// </summary>
        public SellerSyncRentHeadLeaseExtInfo HeadLeaseExtInfo { get; set; }

        /// <summary>
        /// 首租协议
        /// </summary>
        public FileItem HeadLeaseProtocol { get; set; }

        /// <summary>
        /// 历史资产融资扩展信息
        /// </summary>
        public RentHistoricalAssetFinancingExtInfoDTO HistoricalAssetFinancingExtInfo { get; set; }

        /// <summary>
        /// 商品扩展信息
        /// </summary>
        public SellerSyncRentItemExtInfo ItemExtInfo { get; set; }

        /// <summary>
        /// 订单扩展信息
        /// </summary>
        public SellerSyncRentOrderExtInfo OrderExtInfo { get; set; }

        /// <summary>
        /// 交易组件订单Id，取值：租赁下单接口返回的orderId
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务单号，取值：业务方自己的单据号
        /// </summary>
        public string OutBizId { get; set; }

        /// <summary>
        /// 平台服务协议
        /// </summary>
        public FileItem PlatformServiceProtocol { get; set; }

        /// <summary>
        /// 同步场景(枚举值)
        /// </summary>
        public string SyncScene { get; set; }

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
            return "alipay.commerce.rent.order.ext.sync";
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
            parameters.Add("buyer_ext_info", this.BuyerExtInfo);
            parameters.Add("buyer_id", this.BuyerId);
            parameters.Add("buyer_open_id", this.BuyerOpenId);
            parameters.Add("delivery_ext_info", this.DeliveryExtInfo);
            parameters.Add("financing_ext_info", this.FinancingExtInfo);
            parameters.Add("head_lease_ext_info", this.HeadLeaseExtInfo);
            parameters.Add("historical_asset_financing_ext_info", this.HistoricalAssetFinancingExtInfo);
            parameters.Add("item_ext_info", this.ItemExtInfo);
            parameters.Add("order_ext_info", this.OrderExtInfo);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("out_biz_id", this.OutBizId);
            parameters.Add("sync_scene", this.SyncScene);
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
            parameters.Add("buyer_cert_back_pic", this.BuyerCertBackPic);
            parameters.Add("buyer_cert_front_pic", this.BuyerCertFrontPic);
            parameters.Add("buyer_live_pic", this.BuyerLivePic);
            parameters.Add("delivery_received_pic", this.DeliveryReceivedPic);
            parameters.Add("financing_rent_protocol", this.FinancingRentProtocol);
            parameters.Add("head_lease_protocol", this.HeadLeaseProtocol);
            parameters.Add("platform_service_protocol", this.PlatformServiceProtocol);
            return parameters;
        }

        #endregion
    }
}
