var trees = [1,3,2];
var sum = new List<int>();
var allPiceses = new List<int>();

public main(){
consile.writeline( " profit is = " + calculate(trees););
}

public calculate (input){
for(int i; i < input.lenght; i++)
{
    if(input[i]> 3){
 allPiceses.add(cutter(input[i]));
    }
   
    var sum.add(input[i]);
    if(sum.lenght > 2)
    {
        int totalLenght = 0;

        foreach(item in sum){
 totalLenght += intem; 
        }
allPiceses.add(cutter(sum));
    sum = null;
    }
  
  

}
int profit = 0;
for(int i; i < allPiceses.lenght; i++)
{
    if(allPiceses[i] == 1){
profit + = -1;
    }
    if(allPiceses[i] == 2){
profit + = 3;
    }
if(allPiceses[i] == 3){
profit + = 1;
    }
}

}

private cutter(List<int> inputs){
    var result = new List<int>();

for(int i; i < inputs.lenght; i++)
{
    if(inputs[i] > 3 and result.lenght  == 0){
        var newPiece = inputs[i] - 3;
            result.add(newPiece) ;
            result.add(3 - newPiece) ;
    }
    if(result.lenght > 0){
            var newPiece = 3 - inputs[i-1];
            result.add(newPiece) ;
            result.add(3 - newPiece) ;
    }
    esle{
        result.add(inputs[i]);
    }
}
result = result;
}