# ˵��

���ݷ�ʽ: AMF

���ݽӿ�: http://www.semc.gov.cn/aqi/Gateway.aspx

> ���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                          | ����                  | �������� |����ʽ
| ----------------------------- |:--------------------- |:--------:|:--------:|
| GetMaxDayAQI                  |����24Сʱ���AQI      | JSON(AMF)| POST
| GetMaxDayAQI1                 |����24Сʱ���AQI      | JSON(AMF)| POST
| getSHSiteValueData            |����24Сʱƽ��Ũ��     | JSON(AMF)| POST
|
| GetAllCityList                |����24Сʱ��ʷAQI      | JSON(AMF)| POST
| GetAllCityList1               |����24Сʱ��ʷAQI      | JSON(AMF)| POST
| GetValueTrend                 |����24Сʱ��ʷŨ��     | JSON(AMF)| POST
| GetRecentlyDays               |����30����ʷAQI        | JSON(AMF)| POST
|
| getTOP1siteid                 |վ��1Сʱ���AQIվ��   | JSON(AMF)| POST
| getSiteValueData              |վ��1СʱŨ��          | JSON(AMF)| POST
| getSiteAQIData                |վ��1СʱAQI           | JSON(AMF)| POST
| GetSiteValueTrend             |վ��24Сʱ��ʷŨ��     | JSON(AMF)| POST
| GetSiteAqiTrend               |վ��24Сʱ��ʷAQI      | JSON(AMF)| POST
|
| getUpdateTime                 |���ݸ���ʱ��           | JSON(AMF)| POST
|
| _5                            |DSId����               | JSON(AMF)| POST


# ���Ͻӿ�
 - get5Info һ�ΰ�������5����Ϣ�Ľӿڣ���MessageBin�п����ҵ����ֽ�����Ϣ��


# ��֤
���ڷ����������� _Cookie_ �� _DSId_ �ɶ�����֤��
���Ա���ͨ�� `_5` �ӿ������ȡ _DSId_ �� _Cookie_ ��

�нӿڶ��̳��� `semcSrcUrl`
 - ��д **ICacheParam** ��ط���

			 ���� LoadParams ʱ��ͨ�� `_5` ��ȡ _DSId_ ���������
			 _Cookie_ ���ݷ��ص�Header�Ƿ���Set-Cookie�жϣ���������Header��

 - ��д **IParseSrcUrlParam** ��ط���

			 �����Զ���� `_5` �Ľ������ȡ _DSId_ �� _Cookie_��

 - ��д **IMakeParam** ��ط���

			 �����滻DSId���滻stationCode��cityCode��pollutantCode


# �����滻
���� AMF �Ĳ����� HTTP Body ���棬�����Ƕ����Ƶģ���ʹ�ò����滻��
���� MakeRequestBody ��Ϻ�����滻��


> ���ܶ����Ʋ���ʹ�ñ��ָ�ʽ����Ҫ�� AqiParam �����һ�� _replaceDSId_ ��������ָ�������Ʋ����е�ԭʼ _DSId_ ��

> ����ӿ���Ҫ _cityCode_ �� _stationCode_ �� _pollutantCode_ ����������Ҫ�ڲ��������һ�� _replaceCityCode_��_replaceStationCode_ _pollutantCode_ ��������ָ�������Ʋ����е�ԭʼ _cityCode_ �� _stationCode_ �� _pollutantCode_��


# ������ȫ
 - getSiteValueData
 - getSiteAQIData
 - GetSiteValueTrend
 - GetSiteAqiTrend