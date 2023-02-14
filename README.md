# C#(winform) 시리얼 통신 모듈 예제
작성자 : 김응기
- 예제는 winform이지만 wpf 도 로직자체는 동일함.
- 더 좋은 로직이 있으면 작성자와 상의 후 Merge 가능.

### 연동 순서

#### 0. 모듈 내부에 Buffer 사이즈 지정
- 데이터 크기와 설계에 따라 가변적으로 큐버퍼와 종단문자를 지정.
````c#
private const int QUEBUFFSIZE = 2048; //큐버퍼 최대사이즈
private const int RECBUFFSIZE = 2048; //리시브 최대사이즈
private const byte CR = 0x0D; //캐리지 리턴
````

#### 1. Serial_lib 인스턴스 생성
- data bit, parity bit, stop bit의 파라미터는 아직 미구현. 
        추후에 운용자가 자유롭게 모듈내에서 처리 하시길!
````C#
serial = new Serial_lib(comport,rate);
````

#### 2.데이터 리시브 델리게이트 등록
 - byte 배열 데이터가 완성되어있을때 GetReceiveByte  이벤트가 동작하므로 해당 데이터 처리를 하는 함수를 등록하여 준다.
 - DataSendEvent는 콘솔메세지 전용 델리게이트이므로 등록하지 않아도 무관.
````c#
serial.DataSendEvent += new DataGetEventHandler(this.Evt); 
serial.GetReceiveByte += new GetReceiveDataHandler(this.ReceiveByte);
````

#### 3. 커넥션 함수 호출
````C#
serial.Connect()
````

#### 4. 연결 해제 함수 호출
````C#
    if (serial == null)
        {
            MessageBox.Show("연결이 되지 않았습니다.");
            return;
        }
    serial.DisConnect();
````

