# ˵��

���ݷ�ʽ: WebApi

���ݽӿ�: http://111.11.241.103:9001/ashx/

> ���ڽӿڵ�һ���ʰ����󷽷���ͬ���ֲ�ͬ���߼��ӿ�


# �ӿ��б�

| ����                    | ����                   | �������� | ����ʽ
| ----------------------- |:---------------------- |:--------:|:--------:|
| CityShow                | �����б�               | JSON     | GET
| GetCityInfo             | ����1СʱAQI�ȼ�       | JSON	  | GET
| GetCityItemRTData       | ����1СʱAQI           | JSON     | POST(����GET�滻)
| CitySinSite             | ����24СʱAQI��ʷ      | JSON	  | GET
| SiteShow                | ����վ���б�(1СʱAQI) | JSON	  | GET
| GetCityRTData           | ����վ��1СʱŨ��      | JSON	  | GET
| GetItemRTData           | վ��1СʱAQI           | JSON     | POST(����GET�滻)
| SinSite                 | վ��24СʱAQI��ʷ      | JSON     | GET
|
| GetCityRTData_24        | ����վ��24СʱŨ��     | JSON     | GET


# ���ͽӿڣ��߼����ӣ�
  + �ӿ���ͬ��������ͬģ�Ͳ�ͬ
    - GetCityRTData ����typeΪ0ʱ�����¼��1Сʱ
    - GetCityRTData_24 ����typeΪ1ʱ�����¼��24Сʱ

# ���ýӿ�
  + CitySinSite �ӿ��еĲ���typeΪ0ʱ�������ض�����׼��ֵ������
