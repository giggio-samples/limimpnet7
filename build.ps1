Push-Location RustNativeLib
cargo build --release
Pop-Location
Push-Location LibImp
dotnet run
Pop-Location