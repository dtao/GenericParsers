# Yeah, I probably shouldn't use Ruby for this, but I'm lazy.
require "mustache"
require "rake"

IDIOMATIC_TYPE_NAMES = {
  "Boolean"  => "bool",
  "Byte"     => "byte",
  "Int16"    => "short",
  "UInt16"   => "ushort",
  "Int32"    => "int",
  "UInt32"   => "uint",
  "Int64"    => "long",
  "UInt64"   => "ulong",
  "Single"   => "float",
  "Double"   => "double",
  "Decimal"  => "decimal",
  "DateTime" => "DateTime",
  "TimeSpan" => "TimeSpan"
}

desc "Generate C# source files for Parser classes"
task :generate do
  template = File.read(File.expand_path("./templates/SpecificTypeParser.cs.mustache"))

  IDIOMATIC_TYPE_NAMES.each do |type, name|
    generated_source = Mustache.render(template, {
      :type => type,
      :name => name
    })

    puts "Writing #{type}Parser.cs..."
    File.open("#{type}Parser.cs", "w") do |f|
      f.write(generated_source)
    end
  end

  template = File.read(File.expand_path("./templates/Parser.cs.mustache"))
  generated_source = Mustache.render(template, {
    :types => IDIOMATIC_TYPE_NAMES.keys
  })

  puts "Writing Parser.cs..."
  File.open("Parser.cs", "w") do |f|
    f.write(generated_source)
  end

  puts "Done."
end

task :default => :generate
