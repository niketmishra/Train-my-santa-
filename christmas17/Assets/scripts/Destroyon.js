var Seconds = 0.1;

 function Update(){
     Destroy();
 }

 function Destroy(){
     yield WaitForSeconds(Seconds);
     Destroy(gameObject);
 }