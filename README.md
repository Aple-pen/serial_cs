# C#(winform) 시리얼 통신 모듈 예제
작성자 : 김응기
- 예제는 winform이지만 wpf 도 로직자체는 동일함.

### 연동 순서

#### 0. 모듈 내부에 Buffer 사이즈 지정
- 데이터 크기와 설계에 따라 가변적으로 큐버퍼와 종단문자를 지정.
````c#
private const int QUEBUFFSIZE = 2048; //큐버퍼 최대사이즈
private const int RECBUFFSIZE = 2048; //리시브 최대사이즈
private const byte ETX = 0x0D; //종단 문자
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
 - 모듈내에서 에러가 발생 시 GetReceiveErrorHandler 델리게이트로 연동하였음. 해당 이벤트에서 에러처리를 하면 됨.(등록하지 않아도 무관)
 - 이벤트 등록시 람다식으로 표현 가능(3번째 에러 관련 이벤트)
````c#
serial.DataSendEvent += new DataGetEventHandler(this.Evt); 
serial.GetReceiveByte += new GetReceiveDataHandler(this.ReceiveByte);
serial.GetError += new GetReceiveErrorHandler((Exception err) =>
      {
          MessageBox.Show($"문제가 생겼습니다.\n {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      });
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

