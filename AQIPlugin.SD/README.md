# ˵��

���ݷ�ʽ: WebApi

���ݽӿ�: http://58.56.98.78:8801/AirDeploy.web/Ajax/AirQuality/AirQuality.ashx
ͼƬ�ӿ�: http://60.208.91.115:6600/Images

> ������ʽ������ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                    | ����                   | �������� | ����ʽ
| ----------------------- |:---------------------- |:--------:|:--------:|
| GetOther                | ����δ֪����           | δ֪     | GET
| GetCityList             | �����б�               | XML(HTML)| GET
| GetCityAQI              | ����AQI�б�            | JSON     | POST
| GetCityAvg              | ����Ũ��               | JSON     | GET
| GetStationList          | վ���б�               | XML(HTML)| POST
| GetStationMarkOnMap     | վ��λ���б�           | JSON     | GET
| GetQualityItemsValues   | վ��AQI��Ũ��          | JSON     | POST
| GetNjdValue             | վ���ܼ���             | JSON     | POST
| GetVisilbeRank          | �����ܼ�������         | XML(HTML)| POST
|
| Images                  | վ���ܼ�����Ƭ         | JPG      | GET


> ͨ���б�����������ʽ�ܻ��ң�û���κι��ɡ������ų�����ʽ��ͨʹ�õĿ��ܣ�δ���ԣ�


# ����

 + ��ҳ
    1. GetCityList
    2. GetStationList��GetAllSubStation��
    3. GetCityAQI
    4. GetOther
    5. GetStationMarkOnMap


 + ѡ�г���
    1. GetCityAvg
    2. GetStationList��GetStationByStrCode��
    3. HTMLҳ�棨http://58.56.98.78:8801/AirDeploy.web/AirQuality/CityHourAvg.aspx��
    4. GetCityAvg


 + ѡ��վ��
    1. HTMҳ�棨http://58.56.98.78:8801/AirDeploy.web/AirQuality/InfoWindow.aspx��
    2. GetQualityItemsValues
