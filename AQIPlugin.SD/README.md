#˵��

�������ݷ�Ϊ2�֣�HTTP GET��ʽ��POST��ʽ
���ݽӿڵ�ַΪhttp://58.56.98.78:8801/AirDeploy.web/Ajax/AirQuality/AirQuality.ashx
���ڽӿڵ�һ���ʰ�����ʽ��ͬ���ֲ�ͬ������ӿ�


һ��Ϊ�ӿ��б�
����					����				��������		����ʽ
============================================================
GetOther				����δ֪����		δ֪			GET
GetCityList				�����б�			XML(HTML)		GET
GetCityAQI				����AQI�б�			JSON			POST
GetCityAvg				����Ũ��			JSON			GET
GetStationList			վ���б�			XML(HTML)		POST
GetStationMarkOnMap		վ��λ���б�		JSON			GET
GetQualityItemsValues	վ��AQI��Ũ��		JSON			POST
GetNjdValue				վ���ܼ���			JSON			POST
GetVisilbeRank			�����ܼ�������		XML(HTML)		POST
Images					վ���ܼ�����Ƭ		JPG				GET


ͨ���б�����������ʽ�ܻ��ң�û���κι��ɡ������ų�����ʽ��ͨʹ�õĿ��ܣ�δ���ԣ�


����

1����ҳ
GetCityList
GetStationList��GetAllSubStation��
GetCityAQI
GetOther
GetStationMarkOnMap


2��ѡ�г���
GetCityAvg
GetStationList��GetStationByStrCode��
HTMLҳ�棨http://58.56.98.78:8801/AirDeploy.web/AirQuality/CityHourAvg.aspx��
GetCityAvg


3��ѡ��վ��
HTMҳ�棨http://58.56.98.78:8801/AirDeploy.web/AirQuality/InfoWindow.aspx��
GetQualityItemsValues