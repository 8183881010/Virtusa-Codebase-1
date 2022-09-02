create procedure Iseven(@no int)
as
begin
if(@no%2=0)
print 'even no'
else
print 'odd no'
end

exec IsEven 390 