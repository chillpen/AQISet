# ˵��

���ݷ�ʽ: WCF

���ݽӿ�: http://www.ahemc.cn:8016/ClientBin/Env-Publish-Province-RiaService-ProvincePublishDomainService.svc

> ���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                        | ����                 | �������� | ����ʽ
| ----------------------------|:-------------------- |:--------:|:--------:|
| GetAqiCity                  | �����б�             | XML(WCF) | GET
| GetAqiCityStation           | ����վ���б�         | XML(WCF) | GET
| GetAQIDataByCityName        | ����վ��1СʱŨ��    | XML(WCF) | GET
| GetIaqiPublishEtyByCityName | ����վ��1СʱAQI     | XML(WCF) | GET
| GetAQIDay                   | ����վ��24СʱAQI    | XML(WCF) | GET
| GetCityAqiByCityName        | ����1СʱAQI         | XML(WCF) | GET
| GetCityDayAqiByCityName     | ����24СʱAQI        | XML(WCF) | GET
| GetAqiHistoryByCondition    | վ��24Сʱ��ʷŨ��   | XML(WCF) | GET
| GetIaqiHistoryByCondition   | վ��24Сʱ��ʷAQI    | XML(WCF) | GET
| GetAQITips                  | �ȼ���ʾ             | XML(WCF) | GET
| GetSystemConfigs            | ϵͳ����             | XML(WCF) | GET
| GetServerTime               | ϵͳʱ��             | XML(WCF) | POST


# �Զ����ӿڣ��߼����ӣ�

> �Զ���ȡվ�����������GetAqiCityStation�ӿڷ��ص����ݲ���������GetAQIDataByCityName��

  + GetIaqiHistoryByCondition_Auto ������GetAQIDataByCityName�ӿڻ��
  + GetAqiHistoryByCondition_Auto ������GetAQIDataByCityName�ӿڻ��
