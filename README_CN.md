���������GPLЭ�飡



#����Լ��
�����һЩ�������Լ�����˽�Լ�����˽����Ŀ���˼��ĵ���췽ʽ

##����Դ
��ÿ������Դ����ΪIAqiWeb��ͨ��һ����վ��һ��WebService��һ��WCF����һ������Դ

##���ݽӿ�
��ÿ�����ݲ�������ΪISrcUrl��ͨ��һ��WebApi������һ����վURL��һ��WCF��������һ�����ݽӿڡ�����С��λ���Ǳ���Ŀ�ĺ��ġ�




#����Դ

##һ��AQI��������Դ��Ϊ���¼�������
- δ�ּ�
- ������
- ���Ҽ�
- ʡ��
- �м�
- ���ؼ�

���SourceLevelö��

##���������Ϳɷ�Ϊ��
- δ֪����
- ��������
- 2��������
- ���ı�����
- XML����
- JSON����
- WCF����

���DataTypeö��

##IAqiWeb�ӿ�
һ��IAqiWeb�ӿڴ���һ������Դ������Դ��AQI�����������ݽӿ�֮���������

����ԴҪ�����������ݣ���Ψһ��ǩ�����ơ����ݼ������������Լ����ݽӿڵ������ռ伯�ϣ�����Ҫ��������ȡ���ݽӿڼ��ϡ��ķ�����

��������������AQI�������н��й�����Щ������д�Ƚ����ɣ�����Ӱ���κο��������������С�

##IAqiWebʵ��
ͨ������ֱ�Ӽ̳�IAqiWeb�ӿڣ����Ǽ̳�ABaseAqiWeb�࣬�����ʵ���˸���SrcUrlNameSpace���Ի�ȡ���ݽӿڼ��ϡ���ͨ�÷�����
��˴�ABaseAqiWeb�̳е�����Դ����һ��Ҫ��SrcUrlNameSpace����������ȷ��

###TODO
δ���������µ�IAqiWeb�����࣬ʵ�ִ������ļ��ж�ȡ�������ݡ�







#���ݽӿ�

##ISrcUrl�ӿ�
ISrcUrl�ӿ���Ҫʵ�ֺ��ķ���GetData����ȡ���ݡ���ֱ��ʵ�ִ˽ӿ�ֻ�ڴ˷����з���Byte���鼴�ɡ����ڴ������ȡ����Ҫ���н�������ؽ����AQI���������б��洦��
���ݽӿ���Ҫ�������ԣ����ơ��ڲ���ǩ�����ݽӿڵ�ַ��IAqiWeb�ӿڡ����¼�����Ƿ�ʹ�ò�����
������Դ��ͬ���ǣ����¼�����Ƿ�ʹ�ò����������û�Ӱ��AQI�������ĵ��ȡ�

##ISrcUrlʵ��
ͨ����Ҫֱ��ʵ�ִ˽ӿڣ�����ȥ�̳����³�����

������
=====================
ABaseSrcUrl			����WebApi���ݽӿ�
AParamSrcUrl		�в�����Http���ݽӿ�
AWcfSrcUrl			WCFHttpBing�����ݽӿ�
AAmfSrcUrl			FlexAMF�����ݽӿ�
AAdvSrcUrl			�߼����ݽӿ�


��Щ������Ŀǰ�ǲ�����̳й�ϵδȷ�����Ժ���ܻ�����

###ABaseSrcUrl������
Ӧ�Ի���Http GET����Դ���޲���POST����Դ��ֻҪ����ԴURL��������п���ֱ�ӷ������ݣ���ʹ�ô˳����ࡣ
- ABaseSrcUrl�����¼��(UDI����)��չΪSourceUpdataInterval���ԣ�����ʱ��������Ϊö�٣�ʹ��ʱ��������ʵ��SourceUpdataInterval���Լ������ø��¼��(UDI����)��

- ABaseSrcUrl����HTTP GET/POST��չ������HttpType��ӦGET/POST���ַ�ʽ��ʹ��ʱ��������ʵ�ִ����Լ��ɡ�


###AParamSrcUrl������
Ӧ��Http GET/POST����������Դ��Ҫ����Http Header(����Cookie)������Դ���󲿷������������ʹ�ô�������
- ABaseSrcUrlʵ����ISrcUrlParam�ӿڡ�ICacheParam�ӿڡ�IMakeParam�ӿڡ�
	- ISrcUrlParam�ӿ���չ��ISrcUrl�ӿڣ�����֧�ֺ�����GetDate��
	- ICacheParam�ӿ���չ��ISrcUrlParam��EnumParams����ʹ��֧�ֻ��������
	- IMakeParam�ӿ�����չ��ISrcUrlParam��GetData������ƴ�ӡ�

- ABaseSrcUrl�����¼��(UDI����)��չΪSourceUpdataInterval���ԣ�����ʱ��������Ϊö�٣�ʹ��ʱ��������ʵ��SourceUpdataInterval���Լ������ø��¼��(UDI����)��

- ABaseSrcUrl��չ������ParamSendType������������Դʹ�õ�Http������
	- GET
	������URL�У���չParamUrlType����Ŀǰ֧������ƴ��URL��ʽ����
  		Url ? �ź������ֵ�Է�ʽ
  		MVC REST����ȫ·����ʽ
	- POST
	������HTTP Body�У���չParamBodyType����Ŀǰ֧�֣�
  		��ֵ��FORM������
  		���ı�����
  		������(��Base64ȡ��)������

Http GET/POST�������͵ķ�����֧������HTTP Header��
Ĭ�ϵĲ�����Դ��json�ļ�(��ͬ������Դtagͬ��)�����ļ���ȡ���� AqiParam �б�֮����Aqi���������á�

�����������뱣֤ AqiParam �а���

	����       �Ƿ����        ��ʽ                ����
	header     ��ѡ           JsonObject�ı�
	body       ������ѡ       ����ParamBodyType    ParamSendType=POST�Ǳ�ѡ


###AWcfSrcUrl������
��Ӧʹ��WCF HTTP���������Դ��ͨ�������ⶼ����ʹ�ô�����Դ��
WCF�󲿷�����Ҫ����������ʹ��POST�������͵�վ��������������޲�����Ȼ����ʹ��GET������ǰ����HTTP�еı�����ʽ��WCFMessage�Ķ�������ʽ��

WCFMessage��һ���и���Ҫ���XML�ı���
�����ʽĿǰ�޷��������������Ҫ�̳д��࣬����Ҫʵ��MakeWCFMsg��������Map��������ת��ΪWCFMessage��
���������Ҫ���ǶԶ�����WCFMessage�Ĵ������Է��صĽ���ǿ����Զ���ԭΪXML��ʽ��WCFMessage��

- AWcfSrcUrl�̳�AParamSrcUrl�����ࡣ��д��AParamSrcUrl�е�MakeRequestBody����д��ISrcUrl�е�GetData��
	- ��дGetDataȷ��֧���޲���WCF����Դ
	- ��дMakeRequestBody�Ӳ�������MakeWCFMsg����ʵ���л�ȡ���͵�WCFMessage

- AWcfSrcUrlʵ��IExtractData�ӿڣ��������Ƶ�WCFMessageתΪXML�ַ���������ExtractWCFContent�����ж���ȡ����WCFMessage���ǽ�����ȡWCFContent��


###AAmfSrcUrl������
һЩFlex RIAʹ��AMFЭ�鴫�����ݣ�ʹ��HTTP POST�󶨷�ʽ������AAmfSrcUrl�Ǻ������ġ�
AMF��HTTP�еı�����ʽ��AMFMessage�Ķ�������ʽ��

AMFMessage���ڶ����ƶ�����Ϣ��Ŀǰ��û�а취��XML��JSON�����������ݣ�AMFMessage����ֵ֧�ֶ�������ʽ��

- AAmfSrcUrl�̳�AParamSrcUrl�����ࡣParamSendType����Ĭ��ΪPOST����д��AParamSrcUrl�е�MakeRequestHeader��MakeRequestBody��
	- ��дMakeRequestHeader��HTTP header�м��롮Content-Type=application/x-amf��
	- ��дMakeRequestBody�Ӳ���messageType��message�л�ȡ���͵�AMFMessage
- AAmfSrcUrlʵ��IExtractData�ӿڣ��������Ƶ�AMFMessageתΪJSON�ַ�����


###AAdvSrcUrl������
��Ӧ��ȫ�Զ��������Դ
ʵ���˴󲿷ֽӿڣ���Ҫ����ʵ�����еĳ��󷽷���





#�������õĽӿ�
- ISrcUrlParam
- ICacheConfig
- ICacheParam
- IMakeParam
- IExtractData


##ISrcUrlParam�ӿ�
��ISrcUrl�ӿ����߼������ڲ��й�ϵ������һ��������в���ҲӦ��ʵ��ISrcUrl����ΪISrcUrl�������ݽӿڵ�������Ϣ��

##ICacheConfig�ӿ�
�Ƕ���IAqiWeb�ӿڵ���չ���˽ӿ����ڶ�̬���IAqiWeb����ĵ����ݽӿ��Ƿ�����Ϊ�ر�״̬���Ӷ�Ӱ��AQI�������Ƿ�������ݽӿڡ�
###TODO
Ŀǰ��ʵ�ִ˽ӿڵĽ�����ABaseSrcUrl������ӿ�Ŀǰ�Ǹ��Ͻӿڣ���ʵ�ֻ������õĹ���

##ICacheParam�ӿ�
�Ƕ�ISrcUrlParam�ӿڵĵļ�ǿ��ֻ���ڼ�⵽���������ǲŻ���ز���

##IMakeParam�ӿ�
����AParamSrcUrl��AWcfSrcUrl��AAdvSrcUrl����չ������Ӱ��AQI������

##IExtractData�ӿ�
�Ƕ�AWcfSrcUrl��AAmfSrcUrl��AAdvSrcUrl����չ������Ӱ��AQI������

##IParseSrcUrlParam�ӿ�
����AParamSrcUrl��AWcfSrcUrl����չ������Ӱ��AQI������