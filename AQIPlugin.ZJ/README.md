# ˵��

���ݷ�ʽ: AMF

���ݽӿ�: http://218.108.43.220:8099/aqi/messagebroker/amf

> ���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                        | ����                  | �������� | ����ʽ
| ----------------------------|:--------------------- |:--------:|:-------:|
| getOneAndTwoLevelDivision   | �����б�              | JSON(AMF)| POST
| getAreaUsedToDayReport      | ����24Сʱ�б�        | JSON(AMF)| POST
| getAreaUsedToRealTime       | ����1Сʱ�б�         | JSON(AMF)| POST
|
| getAreaDayReprotData        | ����24СʱAQI&Ũ��    | JSON(AMF)| POST
| getAreaRealTimeReportData   | ����1СʱAQI&Ũ��     | JSON(AMF)| POST
|                             | ����24Сʱ��ʷAQI
|
| getHourlyDataForAllSites    | վ��1СʱAQI&Ũ��     | JSON(AMF)| POST
|                             | վ��24Сʱ��ʷAQI
|
| _5                          | DSId����              | JSON(AMF)| POST


# ���Ͻӿ�
 - getAreaRealTimeReportData ��3�ظ��Ͻӿ�
 - getHourlyDataForAllSites ��2�ظ��Ͻӿ�


# ��֤
���ڷ����������� _Cookie_ �� _DSId_ �ɶ�����֤��
���Ա���ͨ�� `_5` �ӿ������ȡ _DSId_ �� _Cookie_ ��

�нӿڶ��̳��� `ZJSrcUrl`
 - ��д **ICacheParam** ��ط���

			 ���� LoadParams ʱ��ͨ�� `_5` ��ȡ _DSId_ ���������
			 _Cookie_ ���ݷ��ص�Header�Ƿ���Set-Cookie�жϣ���������Header��

 - ��д **IParseSrcUrlParam** ��ط���

			 �����Զ���� `_5` �Ľ������ȡ _DSId_ �� _Cookie_��

 - ��д **IMakeParam** ��ط���

			 �����滻DSId


# �����滻
���� AMF �Ĳ����� HTTP Body ���棬�����Ƕ����Ƶģ���ʹ�ò����滻��
���� MakeRequestBody ��Ϻ�����滻��


> ���ܶ����Ʋ���ʹ�ñ��ָ�ʽ����Ҫ�� AqiParam �����һ�� _replaceDSId_ ��������ָ�������Ʋ����е�ԭʼ _DSId_ ��

> ����ӿ���Ҫ _cityCode_ �� _stationCode_ �� _pollutantCode_ ����������Ҫ�ڲ��������һ�� _replaceCityCode_��_replaceStationCode_ _pollutantCode_ ��������ָ�������Ʋ����е�ԭʼ _cityCode_ �� _stationCode_ �� _pollutantCode_��
