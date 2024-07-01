using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarOrderFeeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarOrderFeeInfo : AopObject
    {
        /// <summary>
        /// 基础保障服务费，车生活向商户查询报价时不需要传此此字段；车生活请求商户下单时会传此字段
        /// </summary>
        [XmlElement("basic_guarantee_fee")]
        public RentCarFeeItem BasicGuaranteeFee { get; set; }

        /// <summary>
        /// 租金的每日明细信息，确保加起来等于租金费用总价
        /// </summary>
        [XmlArray("daily_car_rental_fee_detail")]
        [XmlArrayItem("daily_car_rental_fee")]
        public List<DailyCarRentalFee> DailyCarRentalFeeDetail { get; set; }

        /// <summary>
        /// 用户还车时，门店工作人员上门服务的费用
        /// </summary>
        [XmlElement("home_return_fee")]
        public RentCarFeeItem HomeReturnFee { get; set; }

        /// <summary>
        /// 上门送车费
        /// </summary>
        [XmlElement("home_send_fee")]
        public RentCarFeeItem HomeSendFee { get; set; }

        /// <summary>
        /// 更多保障服务费，车生活向商户查询报价时不需要传此字段；若用户选择了更多保障，则车生活请求商户下单时会传此字段
        /// </summary>
        [XmlElement("more_guarantee_service_fee")]
        public RentCarFeeItem MoreGuaranteeServiceFee { get; set; }

        /// <summary>
        /// 夜间还车费
        /// </summary>
        [XmlElement("nigh_return_fee")]
        public RentCarFeeItem NighReturnFee { get; set; }

        /// <summary>
        /// 夜间送车费
        /// </summary>
        [XmlElement("night_send_fee")]
        public RentCarFeeItem NightSendFee { get; set; }

        /// <summary>
        /// 异地还车费用
        /// </summary>
        [XmlElement("offsite_drop_off_fee")]
        public RentCarFeeItem OffsiteDropOffFee { get; set; }

        /// <summary>
        /// 其他费用列表
        /// </summary>
        [XmlArray("other_fee_list")]
        [XmlArrayItem("rent_car_fee_item")]
        public List<RentCarFeeItem> OtherFeeList { get; set; }

        /// <summary>
        /// 租金费用总价
        /// </summary>
        [XmlElement("rent_fee")]
        public RentCarFeeItem RentFee { get; set; }

        /// <summary>
        /// 门店服务费
        /// </summary>
        [XmlElement("store_service_fee")]
        public RentCarFeeItem StoreServiceFee { get; set; }

        /// <summary>
        /// 增值服务费
        /// </summary>
        [XmlArray("value_added_service_fee")]
        [XmlArrayItem("rent_car_fee_item")]
        public List<RentCarFeeItem> ValueAddedServiceFee { get; set; }
    }
}
