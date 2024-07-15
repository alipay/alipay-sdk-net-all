using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomItemExtendDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomItemExtendDetailDTO : AopObject
    {
        /// <summary>
        /// cardType + 唯一 + 储值卡类目投保场景 + 通过上下游约定获取 枚举类型：     STORED("STORED", "储值卡"),     FREQUENCY("FREQUENCY", "次卡"),     TERM("TERM", "周期卡"),
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 储值卡可用金额，单位分
        /// </summary>
        [XmlElement("card_use_amount")]
        public long CardUseAmount { get; set; }

        /// <summary>
        /// 储值卡可用次数
        /// </summary>
        [XmlElement("card_use_count")]
        public long CardUseCount { get; set; }

        /// <summary>
        /// 储值卡使用周期，单位天
        /// </summary>
        [XmlElement("card_use_period")]
        public long CardUsePeriod { get; set; }

        /// <summary>
        /// 充电桩编号
        /// </summary>
        [XmlElement("charge_box_no")]
        public string ChargeBoxNo { get; set; }

        /// <summary>
        /// 充电桩插座总数
        /// </summary>
        [XmlElement("charge_box_plug_total")]
        public long ChargeBoxPlugTotal { get; set; }

        /// <summary>
        /// 充电桩设备类型
        /// </summary>
        [XmlElement("charge_box_type")]
        public string ChargeBoxType { get; set; }

        /// <summary>
        /// 充电站点详细地址
        /// </summary>
        [XmlElement("charge_station_address")]
        public string ChargeStationAddress { get; set; }

        /// <summary>
        /// 充电站点所在地区
        /// </summary>
        [XmlElement("charge_station_area")]
        public string ChargeStationArea { get; set; }

        /// <summary>
        /// 充电站点所在城市
        /// </summary>
        [XmlElement("charge_station_city")]
        public string ChargeStationCity { get; set; }

        /// <summary>
        /// 充电站点编号
        /// </summary>
        [XmlElement("charge_station_no")]
        public string ChargeStationNo { get; set; }

        /// <summary>
        /// 充电站点插座总数
        /// </summary>
        [XmlElement("charge_station_plug_total")]
        public long ChargeStationPlugTotal { get; set; }

        /// <summary>
        /// 充电站点所在省份
        /// </summary>
        [XmlElement("charge_station_prov")]
        public string ChargeStationProv { get; set; }

        /// <summary>
        /// 充电站点所在镇、街道
        /// </summary>
        [XmlElement("charge_station_town")]
        public string ChargeStationTown { get; set; }

        /// <summary>
        /// 充电计费方式
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 免赔金额（元）
        /// </summary>
        [XmlElement("deductible_amount")]
        public long DeductibleAmount { get; set; }

        /// <summary>
        /// extInfo
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品厂保结束时间
        /// </summary>
        [XmlElement("factory_ins_end_time")]
        public string FactoryInsEndTime { get; set; }

        /// <summary>
        /// 游戏帐号
        /// </summary>
        [XmlElement("game_account")]
        public string GameAccount { get; set; }

        /// <summary>
        /// 游戏帐号所属客户端
        /// </summary>
        [XmlElement("game_account_client")]
        public string GameAccountClient { get; set; }

        /// <summary>
        /// 游戏帐号所属客户端id
        /// </summary>
        [XmlElement("game_account_client_id")]
        public string GameAccountClientId { get; set; }

        /// <summary>
        /// 游戏id
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 游戏名称
        /// </summary>
        [XmlElement("game_name")]
        public string GameName { get; set; }

        /// <summary>
        /// 游戏交易模式
        /// </summary>
        [XmlElement("game_trade_mode")]
        public string GameTradeMode { get; set; }

        /// <summary>
        /// 设备是否支持锁定
        /// </summary>
        [XmlElement("lockable_device")]
        public bool LockableDevice { get; set; }

        /// <summary>
        /// 宠物档案id
        /// </summary>
        [XmlElement("pet_id")]
        public string PetId { get; set; }

        /// <summary>
        /// 宠物档案类型
        /// </summary>
        [XmlElement("pet_type")]
        public string PetType { get; set; }

        /// <summary>
        /// 宠物档案版本号
        /// </summary>
        [XmlElement("pet_version")]
        public string PetVersion { get; set; }

        /// <summary>
        /// 插座编号
        /// </summary>
        [XmlElement("plug_no")]
        public string PlugNo { get; set; }

        /// <summary>
        /// 车辆信息
        /// </summary>
        [XmlElement("vehicle")]
        public InsOpenVehicleDTO Vehicle { get; set; }
    }
}
