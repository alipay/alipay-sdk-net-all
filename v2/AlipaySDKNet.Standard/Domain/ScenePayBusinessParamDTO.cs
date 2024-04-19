using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenePayBusinessParamDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScenePayBusinessParamDTO : AopObject
    {
        /// <summary>
        /// 业务自定义参数，交易异步通知和业务单同步查询时会返回
        /// </summary>
        [XmlElement("custom_params")]
        public string CustomParams { get; set; }

        /// <summary>
        /// 命中门店信息
        /// </summary>
        [XmlElement("hit_store_info")]
        public StoreInfoDTO HitStoreInfo { get; set; }

        /// <summary>
        /// 商圈中本次交易发生的商铺的识别号，在同一商铺类型下唯一
        /// </summary>
        [XmlElement("mall_cell_id")]
        public string MallCellId { get; set; }

        /// <summary>
        /// 商圈中本次交易发生的商铺的识别类型，可取值：SMID,SHOPID,STOREID
        /// </summary>
        [XmlElement("mall_cell_type")]
        public string MallCellType { get; set; }

        /// <summary>
        /// 场景支付创建业务单接口中： 当bizScene=MALL_PAY时，必填
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 发生交易的商圈(非商圈组)的partnerId
        /// </summary>
        [XmlElement("mall_pid")]
        public string MallPid { get; set; }

        /// <summary>
        /// 业务单关联的计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 场景支付创建业务单接口中 当bizScene=MALL_PAY时，必填
        /// </summary>
        [XmlElement("real_store_id")]
        public string RealStoreId { get; set; }

        /// <summary>
        /// 业务单关联的券id信息
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
