#[no_mangle]
pub extern "C" fn hello() {
    println!("Hello from Rust!");
}

#[no_mangle]
pub extern "C" fn sum(a: i32, b: i32) -> i32 {
    a + b
}
