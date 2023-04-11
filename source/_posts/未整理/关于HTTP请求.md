~~~http
POST http://localhost:9090/student/add
Content-Type: application/json

{
	"name": "张三",
	"age": 15
}

### Send POST request with body as parameters
POST http://localhost:9090/student/add
Content-Type: application/x-www-form-urlencoded

name=张三&age=20

###

GRT http://localhost:9090/student/add?name=张三&age=20

~~~


实体类

~~~java
@Data
public class Student {
    
    private String name;
    
    private int age;
    
    private int gender;
}
~~~



~~~java
@RestController
@RequestMapping("/student")
public class StudentController {
    
    @RequestMapping("/add")
    public String save(@RequestBody Student student) {
        System.out.println(student);
        return "ok";
    }
    
}
~~~

